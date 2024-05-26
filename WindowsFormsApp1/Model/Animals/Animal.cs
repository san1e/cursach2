using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model.Animals;

namespace WindowsFormsApp1.Animals
{
    public abstract class Animal: IIdentifiable
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public double Age { get; set; }
        public string Gender { get;set; }
        public AnimalType Type { get; protected set; }
        public string Breed { get; private set; }
        public string PhotoLocate { get; set; }

        protected Animal(string name, double age, string gender,string breed, AnimalType type, string photoLocate, Guid id)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Breed = breed;
            Type = type;
            PhotoLocate = photoLocate;
            Id = id;
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
            return $"{Name}; Age: {Age}; Gender: {Gender}; Breed: {Breed}";
        }
    }

}
