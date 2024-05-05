using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {

        private Button RegisterBtn = new Button();

        public LinkLabel linklabel2 = new LinkLabel();
        public LoginForm()
        {
            InitializeComponent();
            RegisterBtn.Click += new System.EventHandler(this.registerButton_Click);
            linklabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = Login.Text;
            string password = Password.Text;

            // Проверка, выбрана ли хотя бы одна из ролей
            if (!userRadioButton.Checked && !sponsorRadioButton.Checked)
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines("users.txt");
                bool isAuthorized = false;

                foreach (string line in lines)
                {
                    string[] parts = line.Split(' ');
                    if (parts.Length == 3)
                    {
                        string fileUsername = parts[0];
                        string filePassword = parts[1];
                        string role = parts[2];

                        if (fileUsername.Equals(username, StringComparison.OrdinalIgnoreCase) && filePassword == password)
                        {
                            // Проверка учетных данных
                            if ((role == "USER" && userRadioButton.Checked) || (role == "ADMIN" && sponsorRadioButton.Checked))
                            {
                                isAuthorized = true;
                                if (role == "USER")
                                {
                                    MainForm mainForm = new MainForm(false);
                                    mainForm.Show();
                                }
                                else if (role == "ADMIN")
                                {
                                    SponsorForm sponsorForm = new SponsorForm();
                                    sponsorForm.Show();
                                }
                                break;
                            }
                        }
                    }
                }

                if (!isAuthorized)
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading from the file: " + ex.Message);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = Login.Text;
            string password = Password.Text;
            string role = userRadioButton.Checked ? "USER" : "ADMIN";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }

            // Проверка, выбрана ли хотя бы одна из ролей
            if (!userRadioButton.Checked && !sponsorRadioButton.Checked)
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            try
            {
                var lines = new List<string>(File.ReadAllLines("users.txt"));
                // Проверка существующих пользователей
                foreach (var line in lines)
                {
                    var parts = line.Split(' ');
                    if (parts[0].Trim().Equals(username, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("This username is already taken. Please choose another.");
                        return;
                    }
                }

                // Добавление нового пользователя
                lines.Add($"{username} {password} {role}");
                File.WriteAllLines("users.txt", lines);

                MessageBox.Show("Registration successful. You can now log in.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to register: " + ex.Message);
            }

            loginButton.Visible = true;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        public void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginButton.Visible = false;
            RegisterBtn.Location = new Point(112, 214);
            RegisterBtn.Text = "REGISTER";
            Controls.Add(RegisterBtn);
            linkLabel1.Visible = false;
            linklabel2.Text = "Login";
            linklabel2.Location = new Point(125, 240);
            Controls.Add(linklabel2 );
        }

        public void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Visible = true;
            loginButton.Visible = true;
        }
    }
}
