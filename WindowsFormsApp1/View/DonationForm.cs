using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.View
{
    public partial class DonationForm : Form
    {
        private ShelterController shelterController;
        private ListBox donationsListBox;

        public decimal Amount { get; private set; }
        public string Description { get; private set; }

        public DonationForm(ShelterController controller, bool isAdmin = false)
        {
            InitializeComponent();
            shelterController = controller;

            if (isAdmin)
            {
                InitializeAdminView();
            }
        }

        private void InitializeAdminView()
        {
            DonateBtn.Visible = false;
            AmountTxt.Visible = false;
            AmountLbl.Visible = false;
            DescriptionLbl.Visible = false;
            DescriptionTxt.Visible = false;

            donationsListBox = new ListBox();
            donationsListBox.Dock = DockStyle.Fill;
            panel1.Size = new Size(450,200);
            panel1.Controls.Add(donationsListBox);
            this.Size = new Size(600,300);
            DisplayDonations();
        }

        private void DisplayDonations()
        {
            List<Expense> donations = shelterController.GetDonations();
            donationsListBox.Items.Clear();

            foreach (Expense donation in donations)
            {
                donationsListBox.Items.Add($"User: {donation.DonorName}; Amount: {donation.Amount:C}; Description: {donation.Description}");
            }
        }

        private void Donate_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(AmountTxt.Text, out decimal amount))
            {
                Amount = amount;
                Description = DescriptionTxt.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }
        private void Amount_TextChanged(object sender, EventArgs e)
        {
            // Удаляем все символы, кроме цифр
            string newText = new string(AmountTxt.Text.Where(c => char.IsDigit(c)).ToArray());
            AmountTxt.Text = newText;

            // Устанавливаем курсор в конец текстового поля
            AmountTxt.SelectionStart = AmountTxt.Text.Length;
        }
        private void DonationForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - (this.Width / 2), (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Height / 2));
        }

        private void DonationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}