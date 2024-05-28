// AddForm.cs
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
using WindowsFormsApp1.Model.Animals;

namespace WindowsFormsApp1.View
{
    public partial class AddForm : Form
    {
        // Зберігає шлях до обраної фотографії
        public string SelectedImagePath { get; private set; }

        // Контролер притулку
        public ShelterController ShelterController { get; set; }


        public AddForm()
        {
            InitializeComponent();
            // Приховуємо PictureBox на початку
            pictureBox1.Visible = false;
            // Вибираємо перший елемент у комбобоксі типів тварин
            AnimalType.SelectedIndex = 0;
            // Оновлюємо комбобокс порід
            UpdateBreedComboBox();
        }

        // Обробник події натискання кнопки "Огляд"
        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            // Створення діалогового вікна "Відкрити файл"
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Встановлення фільтра для відображення лише зображень
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

                // Перевірка, чи користувач обрав файл
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Збереження шляху до обраної фотографії
                    SelectedImagePath = openFileDialog.FileName;

                }
            }
            // Показ PictureBox
            pictureBox1.Visible = true;
            // Встановлення режиму відображення зображення
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            // Встановлення шляху до зображення
            pictureBox1.ImageLocation = SelectedImagePath;
            // Приховуємо Label
            label1.Visible = false;

        }

        // Обробник події завантаження форми
        private void AddForm_Load(object sender, EventArgs e)
        {
            // Центрування форми на екрані
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - (this.Width / 2), (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Height / 2));
        }

        // Метод для оновлення комбобоксу порід
        private void UpdateBreedComboBox()
        {
            // Очищення комбобоксу порід
            breedComboBox.Items.Clear();
            // Очищення текстового поля комбобоксу
            breedComboBox.Text = "";
            // Отримання обраного типу тварини
            string selectedAnimalType = AnimalType.SelectedItem?.ToString() ?? "";

            // Перевірка, чи обраний тип тварини є собакою, котом, хом'яком або птахом
            if (selectedAnimalType == "Dog" || selectedAnimalType == "Cat" || selectedAnimalType == "Hamster" || selectedAnimalType == "Bird")
            {
                // Отримання типу Animal за назвою
                Type animalType = Type.GetType($"WindowsFormsApp1.Animals.{selectedAnimalType}");
                if (animalType != null)
                {
                    // Використання рефлексії для створення екземпляра обраного типу
                    IBreedable animal = (IBreedable)Activator.CreateInstance(animalType,
                        null, // имя
                        0, // возраст
                        null, // пол
                        null, // порода
                        null, // путь к фото
                        Guid.Empty // ID
                    );

                    // Додавання порід до комбобоксу порід
                    breedComboBox.Items.AddRange(animal.Breeds.ToArray());

                    // Вмикання комбобоксу порід
                    breedComboBox.Enabled = true;
                }
            }
            else
            {
                // Вимикання комбобоксу порід
                breedComboBox.Enabled = false;
            }
        }

        // Обробник події натискання кнопки "Додати"
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Отримання імені тварини
            string name = NameTxt.Text;
            // Перевірка, чи вік є дійсним числом
            double age;
            if (!double.TryParse(Age.Text, out age))
            {
                // Відображення повідомлення про помилку
                MessageBox.Show("Please enter a valid age.");
                return;
            }
            // Отримання статі тварини
            string gender = GenderCmb.SelectedItem?.ToString() ?? "";
            // Отримання типу тварини
            string type = AnimalType.SelectedItem?.ToString() ?? "";
            // Отримання породи (якщо вона є)
            string breed = breedComboBox.SelectedItem?.ToString() ?? "";

            // Створення нового об'єкта Animal відповідного типу
            Animal newAnimal;
            switch (type)
            {
                case "Cat":
                    // НЕ генеруємо новий ID, а використовуємо вже існуючий
                    newAnimal = new Cat(name, age, gender, breed, SelectedImagePath, Guid.NewGuid());
                    break;
                case "Dog":
                    newAnimal = new Dog(name, age, gender, breed, SelectedImagePath, Guid.NewGuid());
                    break;
                case "Hamster":
                    newAnimal = new Hamster(name, age, gender, breed, SelectedImagePath, Guid.NewGuid());
                    break;
                case "Bird":
                    newAnimal = new Bird(name, age, gender, breed, SelectedImagePath, Guid.NewGuid());
                    break;
                default:
                    // Відображення повідомлення про помилку
                    MessageBox.Show("Please select a valid animal type.");
                    return;
            }

            // Додавання нової тварини до контролера притулку
            ShelterController.AddAnimal(newAnimal);

            // Закриття форми
            this.Close();
        }

        // Обробник події зміни вибору типу тварини в комбобоксі
        private void AnimalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Оновлення комбобоксу порід
            UpdateBreedComboBox();
        }

        // Обробник події зміни тексту поля "Вік"
        private void Age_TextChanged(object sender, EventArgs e)
        {
            // Видалення всіх символів, крім цифр
            string newText = new string(Age.Text.Where(c => char.IsDigit(c)).ToArray());
            Age.Text = newText;

            // Встановлення курсора в кінець текстового поля
            Age.SelectionStart = Age.Text.Length;
        }
    }
}