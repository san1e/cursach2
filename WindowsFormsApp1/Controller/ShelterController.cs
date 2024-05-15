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
            shelter.LoadAnimalsFromFile();
            if (shelter.Animals.Count == 0)
            {
                shelter.Animals.Add(new Dog("Sem", 3, "Male", "French", "E:\\WindowsFormsApp1\\WindowsFormsApp1\\DogsPhoto\\1.jpg"));
                shelter.Animals.Add(new Cat("Boni", 1, "Female", "E:\\WindowsFormsApp1\\WindowsFormsApp1\\CatsPhoto\\1.png"));
                shelter.Animals.Add(new Bird("Kesha", 0.4, "Female",""));
            }
            
           
        }
        public List<Animal> Animals
        {
            get { return shelter.Animals; }
        }
        public void AddAnimal(Animal animal)
        {
            shelter.AddAnimal(animal);
            shelter.SaveAnimalsToFile();
        }

        public void RemoveAnimal(Animal animal)
        {
            shelter.RemoveAnimal(animal);
            shelter.SaveAnimalsToFile();
        }

        public void AddExpense(string description, decimal amount)
        {
            shelter.AddExpense(description, amount);
        }

        public void RemoveExpense(Expense expense)
        {
            shelter.RemoveExpense(expense);
        }

        public void GetMoreInformation(Animal animal)
        {
            shelter.MoreInformation(animal);
        }

    }

}
