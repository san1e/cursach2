using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Animals
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public double Age { get; set; }
        public string Gender { get;set; }
        public AnimalType Type { get; protected set; }

        public string PhotoLocate { get; set; }

        protected Animal(string name, double age, string gender, AnimalType type, string photoLocate)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Type = type;
            PhotoLocate = photoLocate;
        }
        public virtual string GetDescription()
        {
            return $"This is a {Gender} {Type} named {Name}, {Age} years old.";
        }

        public virtual void Eat()
        {
           MessageBox.Show($"{Name} is eating.");
        }

        public virtual void Play()
        {
            MessageBox.Show($"{Name} is playing.");
        }

        public override string ToString()
        {
            return $"{Name}, Age: {Age}, Gender: {Gender}";
        }
    }

}
