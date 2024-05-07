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

namespace WindowsFormsApp1.View
{
    public partial class DonationForm : Form
    {

        public decimal Amount { get; private set; } // Expose Amount property

        public string Description { get; private set; }

        public DonationForm()
        {
            InitializeComponent();
        }

        private void Donate_Click(object sender, EventArgs e)
        {
            // Parse the amount from the text box
            if (decimal.TryParse(AmountTxt.Text, out decimal amount))
            {
                Amount = amount; // Set the Amount property
                Description = DescriptionTxt.Text;
                DialogResult = DialogResult.OK; // Set dialog result to OK
                Close(); // Close the form
            }
            else
            {
                MessageBox.Show("Please enter a valid amount."); // Display error message
            }
        }
    }
}
