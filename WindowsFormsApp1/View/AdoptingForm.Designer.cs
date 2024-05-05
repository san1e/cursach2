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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories:";
            // 
            // CategoriesCmb
            // 
            this.CategoriesCmb.FormattingEnabled = true;
            this.CategoriesCmb.Items.AddRange(new object[] {
            "All",
            "Cats",
            "Dogs",
            "Hamsters",
            "Others"});
            this.CategoriesCmb.Location = new System.Drawing.Point(78, 20);
            this.CategoriesCmb.Name = "CategoriesCmb";
            this.CategoriesCmb.Size = new System.Drawing.Size(121, 21);
            this.CategoriesCmb.TabIndex = 1;
            this.CategoriesCmb.SelectedIndexChanged += new System.EventHandler(this.CategoriesCmb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
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
            this.AgesCmb.Location = new System.Drawing.Point(261, 20);
            this.AgesCmb.Name = "AgesCmb";
            this.AgesCmb.Size = new System.Drawing.Size(121, 21);
            this.AgesCmb.TabIndex = 3;
            this.AgesCmb.SelectedIndexChanged += new System.EventHandler(this.AgesCmb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
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
            this.GenderCmb.Location = new System.Drawing.Point(449, 20);
            this.GenderCmb.Name = "GenderCmb";
            this.GenderCmb.Size = new System.Drawing.Size(121, 21);
            this.GenderCmb.TabIndex = 5;
            this.GenderCmb.SelectedIndexChanged += new System.EventHandler(this.GenderCmb_SelectedIndexChanged);
            // 
            // AnimalsList
            // 
            this.AnimalsList.FormattingEnabled = true;
            this.AnimalsList.Location = new System.Drawing.Point(15, 47);
            this.AnimalsList.Name = "AnimalsList";
            this.AnimalsList.Size = new System.Drawing.Size(706, 251);
            this.AnimalsList.TabIndex = 7;
            // 
            // AdoptingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 771);
            this.Controls.Add(this.AnimalsList);
            this.Controls.Add(this.GenderCmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AgesCmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CategoriesCmb);
            this.Controls.Add(this.label1);
            this.Name = "AdoptingForm";
            this.Text = "AdoptingForm";
            this.Load += new System.EventHandler(this.AdoptingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox CategoriesCmb;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox AgesCmb;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox GenderCmb;
        public System.Windows.Forms.ListBox AnimalsList;
    }
}