using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model.Animals;
using WindowsFormsApp1.View;

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

        public override void SetupMoreInfoControls(MoreInformation form)
        {
            form.CommandBtn.Visible = false;
        }

        public override string GetDescription()
        {
            return $"Meet {Name}, an energetic and curious {Type} ready to find a loving home. {Name} is about {Age} years old and loves to explore his surroundings and run on his wheel.";
        }

        public override void Play()
        {
            MessageBox.Show($"{Name} is runing in a wheel");
        }
    }
}
