using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Animals
{
    internal class Cat:Animal
    {
        public Cat(string name, double age,string Gender, string photolocate)
       : base(name, age, Gender, AnimalType.Cats,photolocate)
        {
           
        }

        public override string ToString()
        {
            return $"Cat: {base.ToString()}";
        }
    }
}
