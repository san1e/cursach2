using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Animals;

namespace WindowsFormsApp1.Animals
{
    internal class Hamster:Animal, IIdentifiable, IBreedable
    {
        public Hamster(string name, double age, string Gender,string breed, string photolocate, Guid id) : base(name, age, Gender,breed, AnimalType.Hamsters, photolocate, id)
        {

        }
        public List<string> Breeds => new List<string>()
        {
            "Syrian Hamster",
            "Roborovski Hamster",
            "Dwarf Hamster",
            "Chinese Hamster",
            // ... (Другие породы хомяков)
        };
        public override string ToString()
        {
            return $"Hamster: {base.ToString()}";
        }
    }
}
