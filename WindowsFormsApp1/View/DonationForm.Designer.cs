namespace WindowsFormsApp1.View
{
    partial class DonationForm
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
            this.AmountTxt = new System.Windows.Forms.TextBox();
            this.DescriptionTxt = new System.Windows.Forms.TextBox();
            this.AmountLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DonateBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AmountTxt
            // 
            this.AmountTxt.Location = new System.Drawing.Point(11, 28);
            this.AmountTxt.Name = "AmountTxt";
            this.AmountTxt.Size = new System.Drawing.Size(100, 23);
            this.AmountTxt.TabIndex = 0;
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.Location = new System.Drawing.Point(158, 30);
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(168, 23);
            this.DescriptionTxt.TabIndex = 1;
            // 
            // AmountLbl
            // 
            this.AmountLbl.AutoSize = true;
            this.AmountLbl.Location = new System.Drawing.Point(29, 9);
            this.AmountLbl.Name = "AmountLbl";
            this.AmountLbl.Size = new System.Drawing.Size(64, 18);
            this.AmountLbl.TabIndex = 2;
            this.AmountLbl.Text = "Amount";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(204, 9);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(87, 18);
            this.DescriptionLbl.TabIndex = 3;
            this.DescriptionLbl.Text = "Description";
            // 
            // DonateBtn
            // 
            this.DonateBtn.Location = new System.Drawing.Point(118, 72);
            this.DonateBtn.Name = "DonateBtn";
            this.DonateBtn.Size = new System.Drawing.Size(100, 38);
            this.DonateBtn.TabIndex = 4;
            this.DonateBtn.Text = "Donate";
            this.DonateBtn.UseVisualStyleBackColor = true;
            this.DonateBtn.Click += new System.EventHandler(this.Donate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.DonateBtn);
            this.panel1.Controls.Add(this.DescriptionLbl);
            this.panel1.Controls.Add(this.AmountLbl);
            this.panel1.Controls.Add(this.DescriptionTxt);
            this.panel1.Controls.Add(this.AmountTxt);
            this.panel1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(64, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 129);
            this.panel1.TabIndex = 5;
            // 
            // DonationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.OAK41E0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(456, 196);
            this.Controls.Add(this.panel1);
            this.Name = "DonationForm";
            this.Text = "DonationForm";
            this.Load += new System.EventHandler(this.DonationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox AmountTxt;
        private System.Windows.Forms.TextBox DescriptionTxt;
        private System.Windows.Forms.Label AmountLbl;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Button DonateBtn;
        private System.Windows.Forms.Panel panel1;
    }
}