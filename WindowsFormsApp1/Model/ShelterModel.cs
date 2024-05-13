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

        

        public void MoreInformation(Animal animal)
        {
            Form MoreInfo = new MoreInformation(animal);
            MoreInfo.ShowDialog();
        }

    }

}
