using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using WindowsFormsApp1.Animals;
using WindowsFormsApp1.View;

using System.IO;

namespace WindowsFormsApp1.Model
{
    public class ShelterModel
    {
        public List<Animal> Animals { get; set; }
        private const string AnimalsFileName = "animals.txt";
        public List<Expense> Expenses { get; set; }
        public decimal TotalDonation { get; private set; }
        public ShelterModel()
        {
            Animals = new List<Animal>();
            Expenses = new List<Expense>();
        }

        public void LoadAnimalsFromFile()
        {
            if (File.Exists(AnimalsFileName))
            {
                Animals = LoadAnimals(AnimalsFileName);
            }
        }

        public void SaveAnimalsToFile()
        {
            SaveAnimals(Animals, AnimalsFileName);
        }

        private List<Animal> LoadAnimals(string fileName)
        {
            List<Animal> loadedAnimals = new List<Animal>();
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 5) // Переконайтеся, що дані достатньо
                {
                    string type = parts[0].Trim();
                    string name = parts[1].Trim();
                    double age;
                    if (!double.TryParse(parts[2].Trim(), out age)) { continue; }
                    string gender = parts[3].Trim();
                    string photoLocate = parts[4].Trim();
                    string breed = parts.Length > 5 ? parts[5].Trim() : ""; // Порода для собак

                    Animal animal;
                    switch (type)
                    {
                        case "Cat":
                            animal = new Cat(name, age, gender, photoLocate);
                            break;
                        case "Dog":
                            animal = new Dog(name, age, gender, breed, photoLocate);
                            break;
                        case "Hamster":
                            animal = new Hamster(name, age, gender, photoLocate);
                            break;
                        case "Bird":
                            animal = new Bird(name, age, gender, photoLocate);
                            break;
                        default:
                            continue; // Пропустити невідомий тип
                    }
                    loadedAnimals.Add(animal);
                }
            }

            return loadedAnimals;
        }

        // Метод для збереження тварин у файл
        private void SaveAnimals(List<Animal> animals, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (Animal animal in animals)
            {
                string line = $"{animal.GetType().Name},{animal.Name},{animal.Age},{animal.Gender},{animal.PhotoLocate}";
                if (animal is Dog dog)
                {
                    line += $",{dog.Breed}";
                }
                lines.Add(line);
            }

            File.WriteAllLines(fileName, lines);
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
