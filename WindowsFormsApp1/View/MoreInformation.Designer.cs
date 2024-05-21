namespace WindowsFormsApp1.View
{
    partial class MoreInformation
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
            this.AgeLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Desc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CommandBtn = new System.Windows.Forms.Button();
            this.IdLbl = new System.Windows.Forms.Label();
            this.CommandCmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AgeLbl
            // 
            this.AgeLbl.AutoSize = true;
            this.AgeLbl.Location = new System.Drawing.Point(226, 51);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(29, 13);
            this.AgeLbl.TabIndex = 1;
            this.AgeLbl.Text = "Age:";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(226, 27);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(38, 13);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "Name:";
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Location = new System.Drawing.Point(226, 27);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(0, 13);
            this.TypeLbl.TabIndex = 3;
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Location = new System.Drawing.Point(226, 73);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(45, 13);
            this.GenderLbl.TabIndex = 4;
            this.GenderLbl.Text = "Gender:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Desc
            // 
            this.Desc.AutoSize = true;
            this.Desc.Location = new System.Drawing.Point(226, 96);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(63, 13);
            this.Desc.TabIndex = 5;
            this.Desc.Text = "Description:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Feed";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CommandBtn
            // 
            this.CommandBtn.Location = new System.Drawing.Point(73, 274);
            this.CommandBtn.Name = "CommandBtn";
            this.CommandBtn.Size = new System.Drawing.Size(90, 23);
            this.CommandBtn.TabIndex = 8;
            this.CommandBtn.Text = "Command";
            this.CommandBtn.UseVisualStyleBackColor = true;
            this.CommandBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Location = new System.Drawing.Point(15, 9);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(35, 13);
            this.IdLbl.TabIndex = 9;
            this.IdLbl.Text = "label1";
            // 
            // CommandCmb
            // 
            this.CommandCmb.FormattingEnabled = true;
            this.CommandCmb.Location = new System.Drawing.Point(76, 300);
            this.CommandCmb.Name = "CommandCmb";
            this.CommandCmb.Size = new System.Drawing.Size(86, 21);
            this.CommandCmb.TabIndex = 10;
            // 
            // MoreInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 365);
            this.Controls.Add(this.CommandCmb);
            this.Controls.Add(this.IdLbl);
            this.Controls.Add(this.CommandBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.GenderLbl);
            this.Controls.Add(this.TypeLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.AgeLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MoreInformation";
            this.Text = "MoreInformation";
            this.Load += new System.EventHandler(this.MoreInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label TypeLbl;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.Label Desc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CommandBtn;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.ComboBox CommandCmb;
    }
}