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
        // Зберігає посилання на контролер притулку
        private ShelterController shelterController;
        // Зберігає посилання на ListBox для відображення пожертв (тільки для адміністратора)
        private ListBox donationsListBox;

        // Властивості для отримання суми пожертви та опису
        public decimal Amount { get; private set; }
        public string Description { get; private set; }

        // Конструктор форми DonationForm
        public DonationForm(ShelterController controller, bool isAdmin = false)
        {
            InitializeComponent();
            // Зберігає посилання на контролер притулку
            shelterController = controller;

            // Ініціалізація форми для адміністратора, якщо isAdmin = true
            if (isAdmin)
            {
                InitializeAdminView();
            }
        }

        // Метод для ініціалізації форми для адміністратора
        private void InitializeAdminView()
        {
            // Приховування елементів, які не потрібні адміністратору
            DonateBtn.Visible = false;
            AmountTxt.Visible = false;
            AmountLbl.Visible = false;
            DescriptionLbl.Visible = false;
            DescriptionTxt.Visible = false;

            // Створення ListBox для відображення пожертв
            donationsListBox = new ListBox();
            // Встановлення розміру та стилю ListBox
            donationsListBox.Dock = DockStyle.Fill;
            panel1.Size = new Size(450, 200);
            panel1.Controls.Add(donationsListBox);
            this.Size = new Size(600, 300);
            // Відображення пожертв в ListBox
            DisplayDonations();
        }

        // Метод для відображення пожертв в ListBox
        private void DisplayDonations()
        {
            // Отримання списку пожертв з контролера притулку
            List<Expense> donations = shelterController.GetDonations();
            // Очищення ListBox
            donationsListBox.Items.Clear();

            // Додавання пожертв до ListBox
            foreach (Expense donation in donations)
            {
                donationsListBox.Items.Add($"User: {donation.DonorName}; Amount: {donation.Amount:C}; Description: {donation.Description}");
            }
        }

        // Обробник події натискання кнопки "Пожертвувати"
        private void Donate_Click(object sender, EventArgs e)
        {
            // Перевірка, чи введено дійсне число в поле "Сума"
            if (decimal.TryParse(AmountTxt.Text, out decimal amount))
            {
                // Зберігання суми та опису пожертви
                Amount = amount;
                Description = DescriptionTxt.Text;
                // Закриття форми з результатом OK
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                // Відображення повідомлення про помилку
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        // Обробник події зміни тексту поля "Сума"
        private void Amount_TextChanged(object sender, EventArgs e)
        {
            // Видалення всіх символів, крім цифр
            string newText = new string(AmountTxt.Text.Where(c => char.IsDigit(c)).ToArray());
            AmountTxt.Text = newText;

            // Встановлення курсора в кінець текстового поля
            AmountTxt.SelectionStart = AmountTxt.Text.Length;
        }

        // Обробник події завантаження форми
        private void DonationForm_Load(object sender, EventArgs e)
        {
            // Центрування форми на екрані
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - (this.Width / 2), (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Height / 2));
        }

        // Обробник події закриття форми
        private void DonationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}