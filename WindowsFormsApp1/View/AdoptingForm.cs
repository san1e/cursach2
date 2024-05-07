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
        public  ShelterController shelterController;
        public AdoptingForm(string UserType)
        {
            InitializeComponent();
            shelterController = new ShelterController(new ShelterModel());
            CategoriesCmb.SelectedIndex = 0;
            GenderCmb.SelectedIndex = 0;
            AgesCmb.SelectedIndex = 0;
            UpdateTotalDonation();
            if (UserType=="Admin")
            {
                AdminStyle();
            }
        }

        public void AdminStyle()
        {
            AddBtn.Visible = true;

        }

        private void UpdateTotalDonation()
        {
            // Get the total donation amount from the shelter controller's model
            decimal totalDonation = shelterController.shelter.TotalDonation;

            // Update the label text to display the total donation amount
            TotalDonationLabel.Text = $"Total Donated: {totalDonation:C}";
        }
        private void UpdateAnimalList()
        {
            AnimalsList.Items.Clear();

            // Ensure there's a selected item for each combo box
            if (CategoriesCmb.SelectedItem == null || GenderCmb.SelectedItem == null || AgesCmb.SelectedItem == null)
            {
                return;  // If any combo box hasn't been initialized properly, just return without doing anything.
            }

            var filteredAnimals = shelterController.Animals
                .Where(a => (CategoriesCmb.SelectedItem.ToString() == "All" ||
                             (a is Cat && CategoriesCmb.SelectedItem.ToString() == "Cats") ||
                             (a is Dog && CategoriesCmb.SelectedItem.ToString() == "Dogs") ||
                             (a is Hamster && CategoriesCmb.SelectedItem.ToString() == "Hamsters") ||
                             (!(a is Cat) && !(a is Dog) && !(a is Hamster) && CategoriesCmb.SelectedItem.ToString() == "Others")))
                .Where(a => GenderCmb.SelectedItem.ToString() == "All" || a.Gender == GenderCmb.SelectedItem.ToString())
                .Where(a => AgeFilter(a));

            foreach (Animal animal in filteredAnimals)
            {
                AnimalsList.Items.Add(animal.ToString());
            }
        }

        private bool AgeFilter(Animal animal)
        {
            string ageCategory = AgesCmb.SelectedItem.ToString();
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

        private void CategoriesCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAnimalList();
        }

        private void GenderCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAnimalList();
        }

        private void AgesCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAnimalList();
        }

        private void AdoptingForm_Load(object sender, EventArgs e)
        {

        }

        private void AdoptBtn_Click(object sender, EventArgs e)
        {
            if (AnimalsList.SelectedIndex >=0)
            {
                // Get the selected animal's index
                int selectedIndex = AnimalsList.SelectedIndex;

                // Get the selected animal from the shelter controller's list of animals
                Animal selectedAnimal = shelterController.Animals[selectedIndex];

                // Remove the selected animal from the shelter controller
                shelterController.RemoveAnimal(selectedAnimal);

                // Remove the selected animal from the list box
                AnimalsList.Items.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an animal to adopt.");
            }

        }

        private void DonateBtn_Click(object sender, EventArgs e)
        {
            // Create a new instance of the DonationForm
            DonationForm donateForm = new DonationForm();

            // Show the form as a dialog to get the donation information from the user
            DialogResult result = donateForm.ShowDialog();

            // Check if the user clicked the OK button on the donation form
            if (result == DialogResult.OK)
            {
                // Retrieve donation information from the donation form
                decimal amount = donateForm.Amount;
                string description = donateForm.Description;

                // Add the donation as an expense to the shelter controller
                shelterController.AddExpense(description, amount);

                // Update the total donation display
                UpdateTotalDonation();
            }
        }

        private void MoreInfo_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = AnimalsList.SelectedIndex;
                Animal selectedAnimal = shelterController.Animals[selectedIndex];
                shelterController.GetMoreInformation(selectedAnimal);
            }
            catch (Exception)
            {

                MessageBox.Show("Please select an animal to get more information.");
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
           // shelterController.AddAnimal();
        }
    }
}
