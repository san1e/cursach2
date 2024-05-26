using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Animals;

namespace WindowsFormsApp1.Animals
{
    internal class Bird:Animal, IIdentifiable, IBreedable
    {
        public Bird(string name, double age, string Gender,string breed, string photolocate, Guid id) : base(name, age, Gender, breed, AnimalType.Others,photolocate,id)
        {

        }
        public List<string> Breeds => new List<string>()
        {
            "Budgerigar (Parakeet)",
            "Canary",
            "Cockatiel",
            "Finch",
            // ... (Другие породы птиц)
        };
        public override string ToString()
        {
            return $"Bird: {base.ToString()}";
        }
    }
}
