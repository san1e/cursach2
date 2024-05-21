// ShelterModel.cs
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
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1.Model
{
    public class ShelterModel
    {
        public List<Animal> Animals { get; set; }
        private const string AnimalsFileName = "animals.txt";
        private const string DonationsFileName = "donations.txt";
        public List<Expense> Expenses { get; set; }
        public decimal TotalDonation { get; set; }
        public ShelterController shelterController { get; private set; }

        public ShelterModel(ShelterController shelterController)
        {
            Animals = new List<Animal>();
            Expenses = new List<Expense>();
            this.shelterController = shelterController;
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
                if (parts.Length >= 6) // Переконайтеся, що дані достатньо
                {
                    string type = parts[0].Trim();
                    Guid id;
                    if (!Guid.TryParse(parts[1].Trim(), out id)) { continue; }
                    string name = parts[2].Trim();
                    double age;
                    if (!double.TryParse(parts[3].Trim(), out age)) { continue; }
                    string gender = parts[4].Trim();
                    string photoLocate = parts[5].Trim();
                    string breed = parts.Length > 6 ? parts[6].Trim() : ""; // Порода для собак

                    Animal animal;
                    switch (type)
                    {
                        case "Cat":
                            animal = new Cat(name, age, gender, photoLocate, id);
                            break;
                        case "Dog":
                            animal = new Dog(name, age, gender, breed, photoLocate, id);
                            break;
                        case "Hamster":
                            animal = new Hamster(name, age, gender, photoLocate, id);
                            break;
                        case "Bird":
                            animal = new Bird(name, age, gender, photoLocate, id);
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
                string line = $"{animal.GetType().Name},{animal.Id},{animal.Name},{animal.Age},{animal.Gender},{animal.PhotoLocate}";
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

        public void AddExpense(string description, decimal amount, string donorName) // Добавлен параметр donorName
        {
            Expenses.Add(new Expense(description, amount, donorName)); // Используем новый конструктор
            AddDonation(amount);
        }
        public void LoadDonationsFromFile()
        {
            if (File.Exists(DonationsFileName))
            {
                foreach (string line in File.ReadAllLines(DonationsFileName))
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        Expenses.Add(new Expense(parts[2].Trim(), decimal.Parse(parts[1].Trim()), parts[0].Trim()));
                        TotalDonation += decimal.Parse(parts[1].Trim());
                    }
                }
            }
        }

        public void SaveDonationsToFile(string username, decimal amount, string description)
        {
            using (StreamWriter writer = File.AppendText(DonationsFileName))
            {
                writer.WriteLine($"{username},{amount},{description}");
            }
        }
        public void RemoveExpense(Expense expense)
        {
            Expenses.Remove(expense);
        }



        public void MoreInformation(Animal animal)
        {
            Form MoreInfo = new MoreInformation(shelterController, animal);
            MoreInfo.ShowDialog();
        }

    }

}