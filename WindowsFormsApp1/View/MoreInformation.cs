using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Animals;


namespace WindowsFormsApp1.View
{
    public partial class MoreInformation : Form
    {
        public MoreInformation(Animal animal)
        {
            InitializeComponent();
            NameLbl.Text = $"Name: {animal.Name}";
            AgeLbl.Text = $"Age: {animal.Age}";
            GenderLbl.Text = $"Gender: {animal.Gender}";

        }

        private void MoreInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
