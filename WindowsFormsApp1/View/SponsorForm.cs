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
    public partial class SponsorForm : Form
    {
        private ShelterController shelterController;

        public SponsorForm()
        {
            InitializeComponent();
            shelterController = new ShelterController(new ShelterModel());
        }


        private void SponsorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
