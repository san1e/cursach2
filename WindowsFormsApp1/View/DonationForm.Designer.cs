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
            this.SuspendLayout();
            // 
            // AmountTxt
            // 
            this.AmountTxt.Location = new System.Drawing.Point(24, 42);
            this.AmountTxt.Name = "AmountTxt";
            this.AmountTxt.Size = new System.Drawing.Size(100, 20);
            this.AmountTxt.TabIndex = 0;
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.Location = new System.Drawing.Point(202, 42);
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(100, 20);
            this.DescriptionTxt.TabIndex = 1;
            // 
            // AmountLbl
            // 
            this.AmountLbl.AutoSize = true;
            this.AmountLbl.Location = new System.Drawing.Point(49, 23);
            this.AmountLbl.Name = "AmountLbl";
            this.AmountLbl.Size = new System.Drawing.Size(43, 13);
            this.AmountLbl.TabIndex = 2;
            this.AmountLbl.Text = "Amount";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(225, 23);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLbl.TabIndex = 3;
            this.DescriptionLbl.Text = "Description";
            // 
            // DonateBtn
            // 
            this.DonateBtn.Location = new System.Drawing.Point(128, 75);
            this.DonateBtn.Name = "DonateBtn";
            this.DonateBtn.Size = new System.Drawing.Size(75, 23);
            this.DonateBtn.TabIndex = 4;
            this.DonateBtn.Text = "Donate";
            this.DonateBtn.UseVisualStyleBackColor = true;
            this.DonateBtn.Click += new System.EventHandler(this.Donate_Click);
            // 
            // DonationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 110);
            this.Controls.Add(this.DonateBtn);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.AmountLbl);
            this.Controls.Add(this.DescriptionTxt);
            this.Controls.Add(this.AmountTxt);
            this.Name = "DonationForm";
            this.Text = "DonationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AmountTxt;
        private System.Windows.Forms.TextBox DescriptionTxt;
        private System.Windows.Forms.Label AmountLbl;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Button DonateBtn;
    }
}