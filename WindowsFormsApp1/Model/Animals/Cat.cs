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

        public override void SetupMoreInfoControls(MoreInformation form)
        {
            form.CommandBtn.Visible = false;
        }
        public override string ToString()
        {
            return $"Cat: {base.ToString()}";
        }

        public override string GetDescription()
        {
            return $"Meet {Name}, a sweet and affectionate {Breed} {Type} looking for it forever home. At {Age} years old, {Name} is gentle and loves to cuddle.";
        }

        public override void Play()
        {
            MessageBox.Show($"{Name} is playing with the ball.");
        }
    }
}
