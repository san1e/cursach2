using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Animals;

namespace WindowsFormsApp1.Animals
{
    internal class Hamster:Animal, IIdentifiable
    {
        public Hamster(string name, double age, string Gender, string photolocate, Guid id) : base(name, age, Gender, AnimalType.Hamsters, photolocate, id)
        {

        }

        public override string ToString()
        {
            return $"Hamster: {base.ToString()}";
        }
    }
}
