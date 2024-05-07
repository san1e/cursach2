using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using WindowsFormsApp1.Animals;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Model
{
    public class ShelterModel
    {
        public List<Animal> Animals { get; set; }
        public List<Expense> Expenses { get; set; }
        public decimal TotalDonation { get; private set; }
        public ShelterModel()
        {
            Animals = new List<Animal>();
            Expenses = new List<Expense>();
        }
        public void AddDonation(decimal amount)
        {
            TotalDonation += amount; // Add the donation amount to the total
        }

        public void AddAnimal(Animal animal)
        {

            Animals.Add(animal);
        }

        public void RemoveAnimal(Animal animal)
        {
            Animals.Remove(animal);
        }

        public void AddExpense(string description, decimal amount)
        {
            Expenses.Add(new Expense { Description = description, Amount = amount });
            AddDonation(amount);
        }

        public void RemoveExpense(Expense expense)
        {
            Expenses.Remove(expense);
        }

        //public void FilterAnimals(string category, string gender, string ageCategory)
        //{
        //    var filteredAnimals = Animals
        //        .Where(a => (category == "All" ||
        //                     (a is Cat && category == "Cats") ||
        //                     (a is Dog && category == "Dogs") ||
        //                     (a is Hamster && category == "Hamsters") ||
        //                     (!(a is Cat) && !(a is Dog) && !(a is Hamster) && category == "Others")))
        //        .Where(a => gender == "All" || a.Gender == gender)
        //        .Where(a => AgeFilter(a, ageCategory));

        //    // Очищаем список и добавляем отфильтрованных животных
        //    new AdoptingForm().AnimalsList.Items.Clear();
        //    foreach (Animal animal in filteredAnimals)
        //    {
        //        new AdoptingForm().AnimalsList.Items.Add(animal.ToString());
        //    }
        //}

        //private bool AgeFilter(Animal animal, string ageCategory)
        //{
        //    switch (ageCategory)
        //    {
        //        case "All":
        //            return true;
        //        case "Adult":
        //            return animal.Age >= 2 && animal.Age < 7;
        //        case "Kitten/Puppy":
        //            return animal.Age < 2;
        //        case "Senior":
        //            return animal.Age >= 7;
        //        default:
        //            return true;
        //    }
        //}


        public void MoreInformation(Animal animal)
        {
            Form MoreInfo = new MoreInformation(animal);
            MoreInfo.ShowDialog();
        }

    }

}
