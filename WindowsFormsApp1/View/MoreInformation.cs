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
        private ShelterController shelterController;
        Animal animal1;
        public MoreInformation(ShelterController controller,Animal animal)
        {
            InitializeComponent();
            shelterController = controller; // Теперь shelterController инициализирован
            animal1 = animal;
            NameLbl.Text = $"Name: {animal.Name}";
            AgeLbl.Text = $"Age: {animal.Age}";
            GenderLbl.Text = $"Gender: {animal.Gender}";
            BreedLbl.Text = $"Breed: {animal.Breed}";
            Desc.Text = $"Description: {animal.GetDescription()}";
            Desc.MaximumSize = new Size(200, 200);
            pictureBox1.ImageLocation = animal.PhotoLocate;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            IdLbl.Text = $"ID: {animal.Id}";

            CommandCmb.Items.AddRange(new string[] { "Sit", "Stay", "Fetch" }); // Добавьте команды
            CommandCmb.Visible = false; // Сначала не видна

            // Определяем видимость CommandBtn и CommandCmb в зависимости от типа животного
            UpdateCommandVisibility();

        }
        private void UpdateCommandVisibility()
        {
            if (animal1 is Dog)
            {
                CommandBtn.Visible = true;
                CommandCmb.Visible = true;
            }
            else
            {
                CommandBtn.Visible = false;
                CommandCmb.Visible = false;
            }
        }
        private void MoreInformation_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - (this.Width / 2), (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Height / 2));
        }


        private void PlayBtn_Click(object sender, EventArgs e)
        {
            shelterController.AnimalPlay(animal1);
        }

        private void TrainBtn_Click(object sender, EventArgs e)
        {
            if (animal1 is Dog)
            {
                string command = CommandCmb.SelectedItem.ToString();
                shelterController.TrainAnimal(animal1, command);
            }
        }

        private void FeedBtn_Click(object sender, EventArgs e)
        {
            shelterController.AnimalFeed(animal1);
        }

        private void MoreInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
