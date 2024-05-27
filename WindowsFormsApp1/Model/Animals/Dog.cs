using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Model.Animals;

namespace WindowsFormsApp1.Animals
{
    public class Dog:Animal,ITrainable, IIdentifiable, IBreedable
    {
        

        public Dog(string Name, double Age,string Gender, string breed,string photolocate,Guid id)
            : base(Name,Age,Gender,breed, AnimalType.Dogs,photolocate, id)
        {
        }
        public List<string> Breeds => new List<string>()
    {
        "Labrador Retriever",
        "Golden Retriever",
        "German Shepherd",
        "Bulldog",
        "Poodle",
        // ... (Другие породы собак)
    };
        public override string GetDescription()
        {
            return $"This is a {Gender} {Type} named {Name}, {Age} years old, breed {Breed}. Enjoys walks and fetching.";
        }

        public void Train(string command)
        {
            MessageBox.Show($"{Name} is learning the command: {command}");
        }

        public override string ToString()
        {
            return $"Dog: {base.ToString()}";
        }

        public override void Play()
        {
            MessageBox.Show($"{Name} is trying to catch a stick.");
        }
    }
}
