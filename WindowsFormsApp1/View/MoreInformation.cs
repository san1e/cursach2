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
        Animal animal1;
        public MoreInformation(Animal animal)
        {
            InitializeComponent();
            NameLbl.Text = $"Name: {animal.Name}";
            AgeLbl.Text = $"Age: {animal.Age}";
            GenderLbl.Text = $"Gender: {animal.Gender}";
            Desc.Text = $"Description: {animal.GetDescription()}";
            Desc.MaximumSize = new Size(200, 200);
            pictureBox1.ImageLocation = animal.PhotoLocate;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            animal1 = animal;

        }

        private void MoreInformation_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
