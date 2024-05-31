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

        public override void SetupMoreInfoControls(MoreInformation form)
        {
            form.CommandBtn.Visible = false;
        }
        public override string ToString()
        {
            return $"Bird: {base.ToString()}";
        }

        public override string GetDescription()
        {
            return $"Meet {Name}, a vibrant and cheerful {Breed} in search of a forever home. {Name} is about {Age} year old and loves to sing and chirp troughout the day.";
        }

        public override void Play()
        {
            MessageBox.Show($"{Name} is sining");
        }
    }
}
