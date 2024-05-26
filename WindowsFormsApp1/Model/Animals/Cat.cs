using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Animals;

namespace WindowsFormsApp1.Animals
{
    internal class Cat:Animal, IIdentifiable, IBreedable
    {
        public Cat(string name, double age,string Gender,string breed, string photolocate, Guid id)
       : base(name, age, Gender, breed, AnimalType.Cats,photolocate, id)
        {
           
        }

        public List<string> Breeds => new List<string>()
    {
        "Siamese",
        "Persian",
        "Maine Coon",
        "Ragdoll",
        // ... (Другие породы кошек)
    };
        public override string ToString()
        {
            return $"Cat: {base.ToString()}";
        }
    }
}
