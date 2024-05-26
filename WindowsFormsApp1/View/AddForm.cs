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
        public string SelectedImagePath { get; private set; }

        // Додайте властивість для доступу до контролера притулку 
        public ShelterController ShelterController { get; set; }


        public AddForm()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            AnimalType.SelectedIndex = 0;
            UpdateBreedComboBox();
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Встановіть фільтр, щоб показувати тільки зображення
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Збережіть шлях до вибраного файлу
                    SelectedImagePath = openFileDialog.FileName;

                    // Можете відобразити вибране зображення в PictureBox (якщо він у вас є)
                    // pictureBox1.Image = Image.FromFile(SelectedImagePath);
                }
            }
            pictureBox1.Visible = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.ImageLocation = SelectedImagePath;
            label1.Visible = false;

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - (this.Width / 2), (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Height / 2));
        }

        private void UpdateBreedComboBox()
        {
            breedComboBox.Items.Clear(); // Очищаем breedComboBox
            breedComboBox.Text = "";
            // Получаем текущий тип животного из комбобокса
            string selectedAnimalType = AnimalType.SelectedItem?.ToString() ?? "";

            // Если выбранный тип реализует IBreedable, то обновляем список пород
            if (selectedAnimalType == "Dog" || selectedAnimalType == "Cat" || selectedAnimalType == "Hamster" || selectedAnimalType == "Bird")
            {
                Type animalType = Type.GetType($"WindowsFormsApp1.Animals.{selectedAnimalType}");
                if (animalType != null)
                {
                    // Используем рефлексию, чтобы создать экземпляр выбранного типа
                    // Передаем все необходимые параметры конструктора
                    IBreedable animal = (IBreedable)Activator.CreateInstance(animalType,
                        null, // имя
                        0, // возраст
                        null, // пол
                        null, // порода
                        null, // путь к фото
                        Guid.Empty // ID
                    );

                    // Добавляем породы в breedComboBox
                    breedComboBox.Items.AddRange(animal.Breeds.ToArray());

                    breedComboBox.Enabled = true;
                }
            }
            else
            {
                breedComboBox.Enabled = false;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = NameTxt.Text;
            double age;
            if (!double.TryParse(Age.Text, out age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }
            string gender = GenderCmb.SelectedItem?.ToString() ?? "";
            string type = AnimalType.SelectedItem?.ToString() ?? "";
            string breed = breedComboBox.SelectedItem?.ToString() ?? ""; // Отримайте породу, якщо це собака

            // 2. Створіть нову тварину, вибравши правильний тип
            Animal newAnimal;
            switch (type)
            {
                case "Cat":
                    // НЕ генерируем новый ID, а используем уже существующий
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
                    MessageBox.Show("Please select a valid animal type.");
                    return;
            }

            // 3. Додайте тварину до контролера притулку
            ShelterController.AddAnimal(newAnimal);

            // 4. Закрийте форму
            this.Close();
        }
        private void AnimalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBreedComboBox();
        }
        private void Age_TextChanged(object sender, EventArgs e)
        {
            // Удаляем все символы, кроме цифр
            string newText = new string(Age.Text.Where(c => char.IsDigit(c)).ToArray());
            Age.Text = newText;

            // Устанавливаем курсор в конец текстового поля
            Age.SelectionStart = Age.Text.Length;
        }
    }
}