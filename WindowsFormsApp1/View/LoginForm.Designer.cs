namespace WindowsFormsApp1
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.sponsorRadioButton = new System.Windows.Forms.RadioButton();
            this.Password_label = new System.Windows.Forms.Label();
            this.userRadioButton = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Login_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(98, 128);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(152, 21);
            this.Login.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(98, 177);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(152, 21);
            this.Password.TabIndex = 4;
            this.Password.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(126, 283);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(104, 31);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // sponsorRadioButton
            // 
            this.sponsorRadioButton.AutoSize = true;
            this.sponsorRadioButton.Location = new System.Drawing.Point(146, 247);
            this.sponsorRadioButton.Name = "sponsorRadioButton";
            this.sponsorRadioButton.Size = new System.Drawing.Size(66, 19);
            this.sponsorRadioButton.TabIndex = 1;
            this.sponsorRadioButton.TabStop = true;
            this.sponsorRadioButton.Text = "ADMIN";
            this.sponsorRadioButton.UseVisualStyleBackColor = true;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(143, 159);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(64, 15);
            this.Password_label.TabIndex = 6;
            this.Password_label.Text = "Password";
            // 
            // userRadioButton
            // 
            this.userRadioButton.AutoSize = true;
            this.userRadioButton.Location = new System.Drawing.Point(146, 224);
            this.userRadioButton.Name = "userRadioButton";
            this.userRadioButton.Size = new System.Drawing.Size(56, 19);
            this.userRadioButton.TabIndex = 0;
            this.userRadioButton.TabStop = true;
            this.userRadioButton.Text = "USER";
            this.userRadioButton.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(150, 317);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 15);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Location = new System.Drawing.Point(155, 110);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(40, 15);
            this.Login_label.TabIndex = 5;
            this.Login_label.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.Password_label);
            this.panel1.Controls.Add(this.Login_label);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.sponsorRadioButton);
            this.panel1.Controls.Add(this.userRadioButton);
            this.panel1.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(209, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 412);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(256, 179);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 19);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Без_имени;
            this.pictureBox1.Location = new System.Drawing.Point(120, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._273;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 498);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.RadioButton sponsorRadioButton;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.RadioButton userRadioButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}