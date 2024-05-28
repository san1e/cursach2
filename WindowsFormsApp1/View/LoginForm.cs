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
using System.Runtime.CompilerServices;


namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        // Статична змінна для зберігання імені користувача
        public static string username;
        // Кнопка реєстрації
        private Button RegisterBtn = new Button();

        // Посилання на LinkLabel для переходу до форми реєстрації
        public LinkLabel linklabel2 = new LinkLabel();

        // Конструктор форми LoginForm
        public LoginForm()
        {
            InitializeComponent();
            // Додавання обробника події для кнопки реєстрації
            RegisterBtn.Click += new System.EventHandler(this.registerButton_Click);
            // Додавання обробника події для LinkLabel
            linklabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);

        }

        // Обробник події натискання кнопки "Увійти"
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Отримання імені користувача та пароля
            string username = Login.Text;
            string password = Password.Text;

            // Перевірка, чи обрана хоча б одна роль
            if (!userRadioButton.Checked && !sponsorRadioButton.Checked)
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            try
            {
                // Зчитування рядків з файлу "users.txt"
                string[] lines = File.ReadAllLines("users.txt");
                // Перевірка на наявність авторизованого користувача
                bool isAuthorized = false;

                // Цикл по всіх рядках файлу
                foreach (string line in lines)
                {
                    // Розділення рядка на частини
                    string[] parts = line.Split(' ');
                    // Перевірка, чи є достатня кількість частин у рядку
                    if (parts.Length == 3)
                    {
                        // Отримання імені користувача, пароля та ролі з файлу
                        string fileUsername = parts[0];
                        string filePassword = parts[1];
                        string role = parts[2];

                        // Перевірка збігу імені користувача та пароля
                        if (fileUsername.Equals(username, StringComparison.OrdinalIgnoreCase) && filePassword == password)
                        {
                            // Перевірка відповідності ролі
                            if ((role == "USER" && userRadioButton.Checked) || (role == "ADMIN" && sponsorRadioButton.Checked))
                            {
                                // Установка прапора авторизації
                                isAuthorized = true;

                                // Збереження імені користувача
                                LoginForm.username = username;

                                // Створення та відображення форми AdoptingForm в залежності від ролі
                                if (role == "USER")
                                {
                                    AdoptingForm adoptForm = new AdoptingForm("User");
                                    adoptForm.Show();
                                    this.Hide();
                                }
                                else if (role == "ADMIN")
                                {
                                    AdoptingForm adoptForm = new AdoptingForm("Admin");
                                    adoptForm.Show();
                                    this.Hide();
                                }
                                // Переривання циклу після успішної авторизації
                                break;
                            }
                        }
                    }
                }

                // Якщо авторизація не пройшла
                if (!isAuthorized)
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                // Відображення повідомлення про помилку при зчитуванні файлу
                MessageBox.Show("Error reading from the file: " + ex.Message);
            }
        }

        // Обробник події натискання кнопки "Реєстрація"
        private void registerButton_Click(object sender, EventArgs e)
        {
            // Отримання імені користувача, пароля та ролі
            string username = Login.Text;
            string password = Password.Text;
            string role = userRadioButton.Checked ? "USER" : "ADMIN";

            // Перевірка, чи введені ім'я користувача та пароль
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }

            // Перевірка, чи обрана хоча б одна роль
            if (!userRadioButton.Checked && !sponsorRadioButton.Checked)
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            try
            {
                // Зчитування рядків з файлу "users.txt"
                var lines = new List<string>(File.ReadAllLines("users.txt"));
                // Перевірка наявного імені користувача
                foreach (var line in lines)
                {
                    var parts = line.Split(' ');
                    // Перевірка збігу імені користувача
                    if (parts[0].Trim().Equals(username, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("This username is already taken. Please choose another.");
                        return;
                    }
                }

                // Додавання нового користувача до списку
                lines.Add($"{username} {password} {role}");
                // Запис оновленого списку користувачів у файл "users.txt"
                File.WriteAllLines("users.txt", lines);

                // Відображення повідомлення про успішну реєстрацію
                MessageBox.Show("Registration successful. You can now log in.");
            }
            catch (Exception ex)
            {
                // Відображення повідомлення про помилку при реєстрації
                MessageBox.Show("Failed to register: " + ex.Message);
            }

            // Показ кнопки "Увійти"
            loginButton.Visible = true;
        }

        // Обробник події завантаження форми
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Центрування форми на екрані
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - (this.Width / 2), (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Height / 2));
        }

        // Обробник події натискання LinkLabel "Зареєструватись"
        public void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Приховування кнопки "Увійти"
            loginButton.Visible = false;
            // Встановлення положення та розміру кнопки "Реєстрація"
            RegisterBtn.Location = new Point(126, 283);
            RegisterBtn.Size = new Size(104, 31);
            RegisterBtn.Text = "REGISTER";
            // Додавання кнопки "Реєстрація" до панелі
            panel1.Controls.Add(RegisterBtn);
            // Приховування посилання "Зареєструватись"
            linkLabel1.Visible = false;
            // Зміна тексту посилання "Увійти"
            linklabel2.Text = "Login";
            // Встановлення положення посилання "Увійти"
            linklabel2.Location = new Point(160, 317);
            // Додавання посилання "Увійти" до панелі
            panel1.Controls.Add(linklabel2);

        }

        // Обробник події натискання LinkLabel "Увійти"
        public void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Показ посилання "Зареєструватись"
            linkLabel1.Visible = true;
            // Показ кнопки "Увійти"
            loginButton.Visible = true;
        }

        // Обробник події малювання панелі
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Обробник події зміни стану чекбоксу "Показати пароль"
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Вмикання/вимкнення відображення символів пароля
            if (checkBox1.Checked == true)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }
    }
}