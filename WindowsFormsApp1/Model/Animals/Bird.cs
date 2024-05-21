using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Animals;

namespace WindowsFormsApp1.Animals
{
    internal class Bird:Animal, IIdentifiable
    {
        public Bird(string name, double age, string Gender, string photolocate, Guid id) : base(name, age, Gender, AnimalType.Others,photolocate,id)
        {

        }
        
        public override string ToString()
        {
            return $"Bird: {base.ToString()}";
        }
    }
}
