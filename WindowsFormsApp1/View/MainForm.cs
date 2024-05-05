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

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        
        public MainForm(bool isUser)
        {
            InitializeComponent();
            

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AdobtBtn_Click(object sender, EventArgs e)
        {
            Form adopt = new AdoptingForm();
            adopt.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
