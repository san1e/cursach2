using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Animals
{
    internal class Hamster:Animal
    {
        public Hamster(string name, double age, string Gender) : base(name, age, Gender, AnimalType.Hamsters)
        {

        }

        public override string ToString()
        {
            return $"Hamster: {base.ToString()}";
        }
    }
}
