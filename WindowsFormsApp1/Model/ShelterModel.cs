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
        // Список тварин у притулку
        public List<Animal> Animals { get; set; }
        // Ім'я файлу для зберігання даних про тварин
        private const string AnimalsFileName = "animals.txt";
        // Ім'я файлу для зберігання даних про пожертви
        private const string DonationsFileName = "donations.txt";
        // Список витрат притулку
        public List<Expense> Expenses { get; set; }
        // Загальна сума пожертв
        public decimal TotalDonation { get; set; }
        // Контролер притулку
        public ShelterController shelterController { get; private set; }

        // Конструктор класу ShelterModel
        public ShelterModel(ShelterController shelterController)
        {
            // Ініціалізація списків тварин та витрат
            Animals = new List<Animal>();
            Expenses = new List<Expense>();
            // Збереження посилання на контролер притулку
            this.shelterController = shelterController;
        }

        // Метод для завантаження даних про тварин з файлу
        public void LoadAnimalsFromFile()
        {
            // Перевірка наявності файлу з даними про тварин
            if (File.Exists(AnimalsFileName))
            {
                // Завантаження даних з файлу
                Animals = LoadAnimals(AnimalsFileName);
            }
        }

        // Метод для збереження даних про тварин у файл
        public void SaveAnimalsToFile()
        {
            // Збереження даних про тварин у файл
            SaveAnimals(Animals, AnimalsFileName);
        }

        // Приватний метод для завантаження даних про тварин з файлу
        private List<Animal> LoadAnimals(string fileName)
        {
            // Ініціалізація списку для завантажених тварин
            List<Animal> loadedAnimals = new List<Animal>();
            // Зчитування всіх рядків з файлу
            string[] lines = File.ReadAllLines(fileName);

            // Цикл по всіх рядках файлу
            foreach (string line in lines)
            {
                // Розділення рядка на частини
                string[] parts = line.Split(',');
                // Перевірка, чи кількість частин достатня для створення об'єкта Animal
                if (parts.Length >= 6)
                {
                    // Отримання типу тварини
                    string type = parts[0].Trim();
                    // Отримання ID тварини
                    Guid id;
                    // Перевірка, чи ID є дійсним GUID
                    if (!Guid.TryParse(parts[1].Trim(), out id)) { continue; }
                    // Отримання імені тварини
                    string name = parts[2].Trim();
                    // Отримання віку тварини
                    double age;
                    // Перевірка, чи вік є дійсним числом
                    if (!double.TryParse(parts[3].Trim(), out age)) { continue; }
                    // Отримання статі тварини
                    string gender = parts[4].Trim();
                    // Отримання шляху до фотографії тварини
                    string photoLocate = parts[5].Trim();
                    // Отримання породи тварини (якщо вона є)
                    string breed = parts.Length > 6 ? parts[6].Trim() : "";

                    // Створення об'єкта Animal відповідного типу
                    Animal animal;
                    switch (type)
                    {
                        case "Cat":
                            animal = new Cat(name, age, gender, breed, photoLocate, id);
                            break;
                        case "Dog":
                            animal = new Dog(name, age, gender, breed, photoLocate, id);
                            break;
                        case "Hamster":
                            animal = new Hamster(name, age, gender, breed, photoLocate, id);
                            break;
                        case "Bird":
                            animal = new Bird(name, age, gender, breed, photoLocate, id);
                            break;
                        default:
                            continue; // Пропустити невідомий тип
                    }
                    // Додавання тварини до списку
                    loadedAnimals.Add(animal);
                }
            }

            // Повернення списку завантажених тварин
            return loadedAnimals;
        }

        // Метод для збереження даних про тварин у файл
        private void SaveAnimals(List<Animal> animals, string fileName)
        {
            // Ініціалізація списку рядків для збереження
            List<string> lines = new List<string>();

            // Цикл по всіх тваринах у списку
            foreach (Animal animal in animals)
            {
                // Створення рядка для збереження
                string line = $"{animal.GetType().Name},{animal.Id},{animal.Name},{animal.Age},{animal.Gender},{animal.PhotoLocate}";
                // Додавання породи до рядка, якщо тварина - собака
                if (animal is Dog dog)
                {
                    line += $",{dog.Breed}";
                }
                // Додавання рядка до списку
                lines.Add(line);
            }

            // Запис всіх рядків у файл
            File.WriteAllLines(fileName, lines);
        }

        // Метод для додавання пожертви
        public void AddDonation(decimal amount)
        {
            // Додавання суми пожертви до загальної суми
            TotalDonation += amount;
        }

        // Метод для додавання тварини до списку
        public void AddAnimal(Animal animal)
        {
            // Додавання тварини до списку тварин
            Animals.Add(animal);
        }

        // Метод для видалення тварини зі списку
        public void RemoveAnimal(Animal animal)
        {
            // Видалення тварини зі списку тварин
            Animals.Remove(animal);
        }

        // Метод для додавання витрат
        public void AddExpense(string description, decimal amount, string donorName)
        {
            // Додавання витрат до списку витрат
            Expenses.Add(new Expense(description, amount, donorName));
            // Додавання суми витрат до загальної суми пожертв
            AddDonation(amount);
        }

        // Метод для завантаження даних про пожертви з файлу
        public void LoadDonationsFromFile()
        {
            // Перевірка наявності файлу з даними про пожертви
            if (File.Exists(DonationsFileName))
            {
                // Зчитування всіх рядків з файлу
                foreach (string line in File.ReadAllLines(DonationsFileName))
                {
                    // Розділення рядка на частини
                    string[] parts = line.Split(',');
                    // Перевірка, чи кількість частин достатня для створення об'єкта Expense
                    if (parts.Length == 3)
                    {
                        // Додавання витрат до списку витрат
                        Expenses.Add(new Expense(parts[2].Trim(), decimal.Parse(parts[1].Trim()), parts[0].Trim()));
                        // Додавання суми витрат до загальної суми пожертв
                        TotalDonation += decimal.Parse(parts[1].Trim());
                    }
                }
            }
        }

        // Метод для збереження даних про пожертви у файл
        public void SaveDonationsToFile(string username, decimal amount, string description)
        {
            // Відкриття файлу для додавання даних
            using (StreamWriter writer = File.AppendText(DonationsFileName))
            {
                // Запис даних про пожертву у файл
                writer.WriteLine($"{username},{amount},{description}");
            }
        }

        // Метод для видалення витрат
        public void RemoveExpense(Expense expense)
        {
            // Видалення витрат зі списку витрат
            Expenses.Remove(expense);
        }

        // Метод для відображення додаткової інформації про тварину
        public void MoreInformation(Animal animal)
        {
            // Створення форми для відображення додаткової інформації
            Form MoreInfo = new MoreInformation(shelterController, animal);
            // Відображення форми
            MoreInfo.ShowDialog();
        }

    }

}