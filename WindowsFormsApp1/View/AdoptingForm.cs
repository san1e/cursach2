using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Animals;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1
{
    public partial class AdoptingForm : Form
    {
        // Зберігає посилання на контролер притулку
        public ShelterController shelterController;

        // Конструктор форми AdoptingForm
        public AdoptingForm(string UserType)
        {
            InitializeComponent();
            // Створення нового екземпляра контролера притулку та передача посилання на нього
            shelterController = new ShelterController(new ShelterModel(shelterController));
            // Встановлення вибраних елементів у комбобоксах
            CategoriesCmb.SelectedIndex = 0;
            GenderCmb.SelectedIndex = 0;
            AgesCmb.SelectedIndex = 0;
            // Оновлення відображення суми пожертв
            UpdateTotalDonation();
            // Встановлення стилю форми в залежності від типу користувача
            if (UserType == "Admin")
            {
                AdminStyle();
            }
        }

        // Метод для встановлення стилю форми для адміністратора
        public void AdminStyle()
        {
            // Показ кнопки "Додати"
            AddBtn.Visible = true;
            // Зміна тексту кнопки "Усиновити" на "Видалити"
            AdoptBtn.Text = "Remove";
            // Зміна тексту кнопки "Пожертвувати" на "Інформація про пожертви"
            DonateBtn.Text = "Donate Info";
        }

        // Метод для оновлення відображення суми пожертв
        private void UpdateTotalDonation()
        {
            // Отримання загальної суми пожертв з моделі контролера притулку
            decimal totalDonation = shelterController.shelter.TotalDonation;

            // Оновлення тексту мітки для відображення загальної суми пожертв
            TotalDonationLabel.Text = $"Total Donated: {totalDonation:C}";
        }

        // Метод для оновлення списку тварин
        private void UpdateAnimalList()
        {
            // Очищення списку тварин
            AnimalsList.Items.Clear();

            // Перевірка, чи в комбобоксах обрані елементи
            if (CategoriesCmb.SelectedItem == null || GenderCmb.SelectedItem == null || AgesCmb.SelectedItem == null)
            {
                return;  // Якщо будь-який з комбобоксів не ініціалізований, нічого не робити
            }

            // Фільтрація списку тварин за обраними критеріями
            var filteredAnimals = shelterController.Animals
                .Where(a => (CategoriesCmb.SelectedItem.ToString() == "All" ||
                             (a is Cat && CategoriesCmb.SelectedItem.ToString() == "Cat") ||
                             (a is Dog && CategoriesCmb.SelectedItem.ToString() == "Dog") ||
                             (a is Hamster && CategoriesCmb.SelectedItem.ToString() == "Hamster") ||
                             (!(a is Cat) && !(a is Dog) && !(a is Hamster) && CategoriesCmb.SelectedItem.ToString() == "Bird")))
                .Where(a => GenderCmb.SelectedItem.ToString() == "All" || a.Gender == GenderCmb.SelectedItem.ToString())
                .Where(a => AgeFilter(a));

            // Додавання тварин до списку
            foreach (Animal animal in filteredAnimals)
            {
                AnimalsList.Items.Add($"{animal.ToString()}; ID: {animal.Id}");
            }
        }

        // Метод для фільтрації тварин за віком
        private bool AgeFilter(Animal animal)
        {
            // Отримання обраної категорії віку
            string ageCategory = AgesCmb.SelectedItem.ToString();
            // Повернення true, якщо відповідає критеріям фільтра
            switch (ageCategory)
            {
                case "All":
                    return true;
                case "Adult":
                    return animal.Age >= 2 && animal.Age < 7;
                case "Kitten/Puppy":
                    return animal.Age < 2;
                case "Senior":
                    return animal.Age >= 7;
                default:
                    return true;
            }
        }

        // Обробник події зміни вибору в комбобоксі "Категорія"
        private void CategoriesCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Оновлення списку тварин
            UpdateAnimalList();
        }

        // Обробник події зміни вибору в комбобоксі "Стать"
        private void GenderCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Оновлення списку тварин
            UpdateAnimalList();
        }

        // Обробник події зміни вибору в комбобоксі "Вік"
        private void AgesCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Оновлення списку тварин
            UpdateAnimalList();
        }

        // Обробник події завантаження форми
        private void AdoptingForm_Load(object sender, EventArgs e)
        {
            // Центрування форми на екрані
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - (this.Width / 2), (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Height / 2));
        }

        // Обробник події натискання кнопки "Усиновити" / "Видалити"
        private void AdoptBtn_Click(object sender, EventArgs e)
        {
            // Перевірка, чи в списку тварин обрана тварина
            if (AnimalsList.SelectedIndex >= 0)
            {
                // Отримання індексу обраної тварини
                int selectedIndex = AnimalsList.SelectedIndex;

                // Отримання обраної тварини зі списку тварин контролера притулку
                Animal selectedAnimal = shelterController.Animals[selectedIndex];

                // Видалення обраної тварини з контролера притулку
                shelterController.RemoveAnimal(selectedAnimal);

                // Видалення обраної тварини зі списку
                AnimalsList.Items.RemoveAt(selectedIndex);
            }
            else
            {
                // Відображення повідомлення про помилку
                MessageBox.Show("Please select an animal to adopt.");
            }

        }

        // Обробник події натискання кнопки "Пожертвувати" / "Інформація про пожертви"
        private void DonateBtn_Click(object sender, EventArgs e)
        {
            // Створення форми для пожертв
            DonationForm donateForm = new DonationForm(shelterController, AdoptBtn.Text == "Remove");

            // Відображення форми для пожертв
            DialogResult result = donateForm.ShowDialog();

            // Перевірка, чи користувач ввів дані про пожертву
            if (result == DialogResult.OK && AdoptBtn.Text != "Remove")
            {
                // Отримання суми пожертви та опису з форми
                decimal amount = donateForm.Amount;
                string description = donateForm.Description;

                // Додавання пожертви до контролера притулку
                shelterController.AddExpense(LoginForm.username, amount, description);
                // Оновлення відображення суми пожертв
                UpdateTotalDonation();
            }
        }


        // Обробник події натискання кнопки "Додаткова інформація"
        private void MoreInfo_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримання індексу обраної тварини
                int selectedIndex = AnimalsList.SelectedIndex;
                // Отримання обраної тварини зі списку тварин контролера притулку
                Animal selectedAnimal = shelterController.Animals[selectedIndex];
                // Створення форми для відображення додаткової інформації
                MoreInformation moreInfoForm = new MoreInformation(shelterController, selectedAnimal);
                // Відображення форми
                moreInfoForm.ShowDialog();
            }
            catch (Exception)
            {
                // Відображення повідомлення про помилку
                MessageBox.Show("Please select an animal to get more information.");
            }
        }

        // Обробник події натискання кнопки "Додати"
        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Створення форми для додавання тварини
            AddForm addForm = new AddForm();

            // Передача посилання на контролер притулку до форми додавання
            addForm.ShelterController = this.shelterController;

            // Відкриття форми для додавання як діалогове вікно
            addForm.ShowDialog();
            // Оновлення списку тварин після закриття форми додавання
            UpdateAnimalList();
        }

        // Обробник події закриття форми
        private void AdoptingForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            // Створення форми входу
            LoginForm log = new LoginForm();
            // Показ форми входу
            log.Show();
        }
    }
}