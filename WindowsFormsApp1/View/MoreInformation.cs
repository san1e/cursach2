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
    public partial class MoreInformation : Form
    {
        // Зберігає посилання на контролер притулку
        private ShelterController shelterController;
        // Зберігає посилання на тварину
        Animal animal1;

        // Конструктор форми MoreInformation
        public MoreInformation(ShelterController controller, Animal animal)
        {
            InitializeComponent();
            // Ініціалізація shelterController
            shelterController = controller;
            // Зберігання посилання на тварину
            animal1 = animal;
            // Встановлення текстових міток з інформацією про тварину
            NameLbl.Text = $"Name: {animal.Name}";
            AgeLbl.Text = $"Age: {animal.Age}";
            GenderLbl.Text = $"Gender: {animal.Gender}";
            BreedLbl.Text = $"Breed: {animal.Breed}";
            Desc.Text = $"Description: {animal.GetDescription()}";
            // Встановлення максимального розміру мітки Desc
            Desc.MaximumSize = new Size(200, 200);
            // Завантаження фотографії тварини
            pictureBox1.ImageLocation = animal.PhotoLocate;
            // Встановлення режиму відображення фотографії
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            // Встановлення мітки з ID тварини
            IdLbl.Text = $"ID: {animal.Id}";

            // Додавання команд до комбобоксу
            CommandCmb.Items.AddRange(new string[] { "Sit", "Stay", "Fetch" });
            // Приховування комбобоксу
            CommandCmb.Visible = false;
            animal1.SetupMoreInfoControls(this);
            // Оновлення видимості кнопки "Навчити" та комбобоксу в залежності від типу тварини
            //UpdateCommandVisibility();

        }

        // Метод для оновлення видимості кнопки "Навчити" та комбобоксу
       

        // Обробник події завантаження форми
        private void MoreInformation_Load(object sender, EventArgs e)
        {
            // Центрування форми на екрані
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - (this.Width / 2), (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Height / 2));
        }

        // Обробник події натискання кнопки "Грати"
        private void PlayBtn_Click(object sender, EventArgs e)
        {
            // Виклик методу AnimalPlay() контролера для гри з твариною
            shelterController.AnimalPlay(animal1);
        }

        // Обробник події натискання кнопки "Навчити"
        private void TrainBtn_Click(object sender, EventArgs e)
        {
            // Перевірка, чи тварина є собакою
            if (animal1 is Dog)
            {
                // Отримання команди з комбобоксу
                string command = CommandCmb.SelectedItem.ToString();
                // Виклик методу TrainAnimal() контролера для навчання тварини
                shelterController.TrainAnimal(animal1, command);
            }
        }

        // Обробник події натискання кнопки "Годувати"
        private void FeedBtn_Click(object sender, EventArgs e)
        {
            // Виклик методу AnimalFeed() контролера для годування тварини
            shelterController.AnimalFeed(animal1);
        }

        // Обробник події закриття форми
        private void MoreInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}