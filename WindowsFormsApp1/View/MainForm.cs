using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private string userType;
        public MainForm(string typeUser)
        {
            InitializeComponent();
            if (typeUser == "Admin")
            {
                label1.Visible = false;
                AdobtBtn.Location = new Point(100, 40);
                LostBtn.Location = new Point(450, 40);
                this.Size = new Size(816, 150);
                userType = typeUser;
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AdobtBtn_Click(object sender, EventArgs e)
        {
            Form adopt = new AdoptingForm(userType);
            adopt.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LostBtn_Click(object sender, EventArgs e)
        {
            Form lost_found = new Lost_Found();
            lost_found.ShowDialog();
        }
    }
}
