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

namespace WindowsFormsApp1
{
    public partial class AdoptingForm : Form
    {
        public  ShelterController shelterController;
        public AdoptingForm()
        {
            InitializeComponent();
            shelterController = new ShelterController(new ShelterModel());
            CategoriesCmb.SelectedIndex = 0;
            GenderCmb.SelectedIndex = 0;
            AgesCmb.SelectedIndex = 0;
            UpdateAnimalsList();
        }

        private void UpdateAnimalsList()
        {
            AnimalsList.Items.Clear(); // Clear existing items before adding new ones

            // Get the list of animals from the shelter controller
            List<Animal> animals = shelterController.shelter.Animals;

            // Add each animal's information to the list box
            foreach (Animal animal in animals)
            {
                string displayText;
                if (animal is Cat)
                {
                    displayText = animal.ToString() ;
                }
                else if (animal is Dog)
                {
                     displayText = animal.ToString();
                }
                else
                {
                    displayText = animal.ToString(); // Handle other animal types (if applicable)
                }
                AnimalsList.Items.Add(displayText);
            }
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
    }
}
