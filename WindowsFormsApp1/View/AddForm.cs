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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Name.Text;
            double age;
            if (!double.TryParse(Age.Text, out age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }
            string gender = GenderCmb.SelectedItem?.ToString() ?? "";
            string type = AnimalType.SelectedItem?.ToString() ?? "";
            string breed = BreedTxt.Text; // Отримайте породу, якщо це собака

            // 2. Створіть нову тварину, вибравши правильний тип
            Animal newAnimal;
            switch (type)
            {
                case "Cats":
                    // НЕ генерируем новый ID, а используем уже существующий
                    newAnimal = new Cat(name, age, gender, SelectedImagePath, Guid.NewGuid());
                    break;
                case "Dogs":
                    newAnimal = new Dog(name, age, gender, breed, SelectedImagePath, Guid.NewGuid());
                    break;
                case "Hamsters":
                    newAnimal = new Hamster(name, age, gender, SelectedImagePath, Guid.NewGuid());
                    break;
                case "Others":
                    newAnimal = new Bird(name, age, gender, SelectedImagePath, Guid.NewGuid());
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
    }
}