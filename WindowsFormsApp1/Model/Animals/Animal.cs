using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Animals
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public double Age { get; set; }
        public string Gender { get;set; }
        public AnimalType Type { get; protected set; }

        protected Animal(string name, double age, string gender, AnimalType type)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Type = type;
        }

        public virtual void DoSmth()
        {

        }

        public override string ToString()
        {
            return $"{Name}, Age: {Age}, Gender: {Gender}";
        }
    }

}
