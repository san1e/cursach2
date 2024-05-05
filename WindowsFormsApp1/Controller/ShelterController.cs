using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Animals;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Controller
{
    public class ShelterController
    {
        public ShelterModel shelter;

        public ShelterController(ShelterModel shelter)
        {
            this.shelter = shelter;
            shelter.Animals.Add(new Dog("Sem", 3, "Male", "French"));
            shelter.Animals.Add(new Cat("Boni", 1, "Female"));
            shelter.Animals.Add(new Bird("Kesha", 0.4, "Female"));
        }
        public List<Animal> Animals
        {
            get { return shelter.Animals; }
        }
        public void AddAnimal(object sender, EventArgs e, Animal animal)
        {
            shelter.AddAnimal(animal);
        }

        public void RemoveAnimal(object sender, EventArgs e, Animal animal)
        {
            shelter.RemoveAnimal(animal);
        }

        public void AddExpense(string description, decimal amount)
        {
            shelter.AddExpense(description, amount);
        }

        public void RemoveExpense(Expense expense)
        {
            shelter.RemoveExpense(expense);
        }

    }

}
