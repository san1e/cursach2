namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.AdobtBtn = new System.Windows.Forms.Button();
            this.LostBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdobtBtn
            // 
            this.AdobtBtn.Location = new System.Drawing.Point(100, 220);
            this.AdobtBtn.Name = "AdobtBtn";
            this.AdobtBtn.Size = new System.Drawing.Size(234, 49);
            this.AdobtBtn.TabIndex = 0;
            this.AdobtBtn.Text = "Adopting";
            this.AdobtBtn.UseVisualStyleBackColor = true;
            this.AdobtBtn.Click += new System.EventHandler(this.AdobtBtn_Click);
            // 
            // LostBtn
            // 
            this.LostBtn.Location = new System.Drawing.Point(457, 220);
            this.LostBtn.Name = "LostBtn";
            this.LostBtn.Size = new System.Drawing.Size(234, 49);
            this.LostBtn.TabIndex = 1;
            this.LostBtn.Text = "Lost & Found";
            this.LostBtn.UseVisualStyleBackColor = true;
            this.LostBtn.Click += new System.EventHandler(this.LostBtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 179);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thank you for your interest in adopting an animal! All visits are now by appointm" +
    "ent only and slots will only be released 7 days beforehand. Book an appointment " +
    "here.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LostBtn);
            this.Controls.Add(this.AdobtBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdobtBtn;
        private System.Windows.Forms.Button LostBtn;
        private System.Windows.Forms.Label label1;
    }
}