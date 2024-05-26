namespace WindowsFormsApp1
{
    partial class AdoptingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CategoriesCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AgesCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GenderCmb = new System.Windows.Forms.ComboBox();
            this.AnimalsList = new System.Windows.Forms.ListBox();
            this.AdoptBtn = new System.Windows.Forms.Button();
            this.DonateBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TotalDonationLabel = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories:";
            // 
            // CategoriesCmb
            // 
            this.CategoriesCmb.FormattingEnabled = true;
            this.CategoriesCmb.Items.AddRange(new object[] {
            "All",
            "Cat",
            "Dog",
            "Hamster",
            "Bird"});
            this.CategoriesCmb.Location = new System.Drawing.Point(98, 21);
            this.CategoriesCmb.Name = "CategoriesCmb";
            this.CategoriesCmb.Size = new System.Drawing.Size(121, 26);
            this.CategoriesCmb.TabIndex = 1;
            this.CategoriesCmb.SelectedIndexChanged += new System.EventHandler(this.CategoriesCmb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ages:";
            // 
            // AgesCmb
            // 
            this.AgesCmb.FormattingEnabled = true;
            this.AgesCmb.Items.AddRange(new object[] {
            "All",
            "Adult",
            "Kitten/Puppy",
            "Senior"});
            this.AgesCmb.Location = new System.Drawing.Point(275, 21);
            this.AgesCmb.Name = "AgesCmb";
            this.AgesCmb.Size = new System.Drawing.Size(121, 26);
            this.AgesCmb.TabIndex = 3;
            this.AgesCmb.SelectedIndexChanged += new System.EventHandler(this.AgesCmb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender:";
            // 
            // GenderCmb
            // 
            this.GenderCmb.FormattingEnabled = true;
            this.GenderCmb.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female"});
            this.GenderCmb.Location = new System.Drawing.Point(468, 21);
            this.GenderCmb.Name = "GenderCmb";
            this.GenderCmb.Size = new System.Drawing.Size(121, 26);
            this.GenderCmb.TabIndex = 5;
            this.GenderCmb.SelectedIndexChanged += new System.EventHandler(this.GenderCmb_SelectedIndexChanged);
            // 
            // AnimalsList
            // 
            this.AnimalsList.FormattingEnabled = true;
            this.AnimalsList.ItemHeight = 18;
            this.AnimalsList.Location = new System.Drawing.Point(19, 53);
            this.AnimalsList.Name = "AnimalsList";
            this.AnimalsList.Size = new System.Drawing.Size(706, 238);
            this.AnimalsList.TabIndex = 7;
            // 
            // AdoptBtn
            // 
            this.AdoptBtn.Location = new System.Drawing.Point(143, 310);
            this.AdoptBtn.Name = "AdoptBtn";
            this.AdoptBtn.Size = new System.Drawing.Size(116, 30);
            this.AdoptBtn.TabIndex = 8;
            this.AdoptBtn.Text = "Adopt";
            this.AdoptBtn.UseVisualStyleBackColor = true;
            this.AdoptBtn.Click += new System.EventHandler(this.AdoptBtn_Click);
            // 
            // DonateBtn
            // 
            this.DonateBtn.Location = new System.Drawing.Point(265, 311);
            this.DonateBtn.Name = "DonateBtn";
            this.DonateBtn.Size = new System.Drawing.Size(116, 30);
            this.DonateBtn.TabIndex = 9;
            this.DonateBtn.Text = "Donate";
            this.DonateBtn.UseVisualStyleBackColor = true;
            this.DonateBtn.Click += new System.EventHandler(this.DonateBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(387, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 30);
            this.button3.TabIndex = 10;
            this.button3.Text = "MoreInformation";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.MoreInfo_Click);
            // 
            // TotalDonationLabel
            // 
            this.TotalDonationLabel.AutoSize = true;
            this.TotalDonationLabel.Location = new System.Drawing.Point(535, 316);
            this.TotalDonationLabel.Name = "TotalDonationLabel";
            this.TotalDonationLabel.Size = new System.Drawing.Size(145, 18);
            this.TotalDonationLabel.TabIndex = 12;
            this.TotalDonationLabel.Text = " TotalDonationLabel";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(21, 310);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(116, 30);
            this.AddBtn.TabIndex = 13;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Visible = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.TotalDonationLabel);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.DonateBtn);
            this.panel1.Controls.Add(this.AdoptBtn);
            this.panel1.Controls.Add(this.AnimalsList);
            this.panel1.Controls.Add(this.GenderCmb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AgesCmb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CategoriesCmb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(56, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 364);
            this.panel1.TabIndex = 14;
            // 
            // AdoptingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._596;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 478);
            this.Controls.Add(this.panel1);
            this.Name = "AdoptingForm";
            this.Text = "AdoptingForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdoptingForm_FormClosed);
            this.Load += new System.EventHandler(this.AdoptingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox CategoriesCmb;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox AgesCmb;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox GenderCmb;
        public System.Windows.Forms.ListBox AnimalsList;
        private System.Windows.Forms.Button AdoptBtn;
        private System.Windows.Forms.Button DonateBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label TotalDonationLabel;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Panel panel1;
    }
}