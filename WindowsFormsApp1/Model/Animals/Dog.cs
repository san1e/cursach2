using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Animals
{
    internal class Dog:Animal
    {
        public string Breed { get; private set; }

        public Dog(string Name, double Age,string Gender, string breed)
            : base(Name,Age,Gender, AnimalType.Dogs)
        {
            Breed = breed;
        }

        public override string ToString()
        {
            return $"Dog: {base.ToString()}, Breed: {Breed}";
        }
    }
}
