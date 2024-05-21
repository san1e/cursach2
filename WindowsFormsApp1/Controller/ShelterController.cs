// ShelterController.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Animals;
using WindowsFormsApp1.Model;
using System.Windows.Forms;
using WindowsFormsApp1.Model.Animals;

namespace WindowsFormsApp1.Controller
{
    public class ShelterController
    {
        public ShelterModel shelter;

        public ShelterController(ShelterModel shelter)
        {
            this.shelter = shelter;
            shelter.LoadAnimalsFromFile();
            shelter.LoadDonationsFromFile();
            shelter.LoadAnimalsFromFile();
            if (shelter.Animals.Count == 0)
            {
                // Передайте Guid.NewGuid() для ID 
                shelter.Animals.Add(new Dog("Sem", 3, "Male", "French", "E:\\WindowsFormsApp1\\WindowsFormsApp1\\DogsPhoto\\1.jpg", Guid.NewGuid()));
                shelter.Animals.Add(new Cat("Boni", 1, "Female", "E:\\WindowsFormsApp1\\WindowsFormsApp1\\CatsPhoto\\1.png", Guid.NewGuid()));
                shelter.Animals.Add(new Bird("Kesha", 0.4, "Female", "", Guid.NewGuid()));
            }
            // ... (остальной код)
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

        public void AddExpense(string username, decimal amount, string description) // Добавлен параметр donorName
        {
            shelter.AddExpense(description, amount, username); // Добавляем имя пользователя в Expense
            shelter.SaveDonationsToFile(username, amount, description);
        }
        public List<Expense> GetDonations()
        {
            return shelter.Expenses;
        }

        public void RemoveExpense(Expense expense)
        {
            shelter.RemoveExpense(expense);
        }

        public void GetMoreInformation(Animal animal)
        {
            shelter.MoreInformation(animal);
        }

        public void AnimalPlay(Animal animal)
        {
            animal.Play();
        }

        public void TrainAnimal(Animal animal, string command)
        {
            if (animal is ITrainable trainableAnimal)
            {
                trainableAnimal.Train(command);
            }
            else
            {
                MessageBox.Show("This animal cannot be trained.");
            }
        }

        public void AnimalFeed(Animal animal)
        {
            animal.Eat();
        }
    }

}