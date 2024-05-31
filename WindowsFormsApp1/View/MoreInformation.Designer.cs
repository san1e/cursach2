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
            this.Desc = new System.Windows.Forms.Label();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CommandBtn = new System.Windows.Forms.Button();
            this.IdLbl = new System.Windows.Forms.Label();
            this.CommandCmb = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BreedLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AgeLbl
            // 
            this.AgeLbl.AutoSize = true;
            this.AgeLbl.Location = new System.Drawing.Point(218, 75);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(38, 18);
            this.AgeLbl.TabIndex = 1;
            this.AgeLbl.Text = "Age:";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(218, 43);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(52, 18);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "Name:";
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Location = new System.Drawing.Point(218, 43);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(0, 18);
            this.TypeLbl.TabIndex = 3;
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Location = new System.Drawing.Point(218, 112);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(60, 18);
            this.GenderLbl.TabIndex = 4;
            this.GenderLbl.Text = "Gender:";
            // 
            // Desc
            // 
            this.Desc.AutoSize = true;
            this.Desc.Location = new System.Drawing.Point(218, 191);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(90, 18);
            this.Desc.TabIndex = 5;
            this.Desc.Text = "Description:";
            // 
            // PlayBtn
            // 
            this.PlayBtn.Location = new System.Drawing.Point(4, 290);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(55, 37);
            this.PlayBtn.TabIndex = 6;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Feed";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.FeedBtn_Click);
            // 
            // CommandBtn
            // 
            this.CommandBtn.Location = new System.Drawing.Point(65, 290);
            this.CommandBtn.Name = "CommandBtn";
            this.CommandBtn.Size = new System.Drawing.Size(90, 37);
            this.CommandBtn.TabIndex = 8;
            this.CommandBtn.Text = "Command";
            this.CommandBtn.UseVisualStyleBackColor = true;
            this.CommandBtn.Click += new System.EventHandler(this.TrainBtn_Click);
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Location = new System.Drawing.Point(7, 13);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(46, 18);
            this.IdLbl.TabIndex = 9;
            this.IdLbl.Text = "label1";
            // 
            // CommandCmb
            // 
            this.CommandCmb.FormattingEnabled = true;
            this.CommandCmb.Location = new System.Drawing.Point(65, 330);
            this.CommandCmb.Name = "CommandCmb";
            this.CommandCmb.Size = new System.Drawing.Size(90, 26);
            this.CommandCmb.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.BreedLbl);
            this.panel1.Controls.Add(this.CommandCmb);
            this.panel1.Controls.Add(this.IdLbl);
            this.panel1.Controls.Add(this.CommandBtn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.PlayBtn);
            this.panel1.Controls.Add(this.Desc);
            this.panel1.Controls.Add(this.GenderLbl);
            this.panel1.Controls.Add(this.TypeLbl);
            this.panel1.Controls.Add(this.NameLbl);
            this.panel1.Controls.Add(this.AgeLbl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(88, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 364);
            this.panel1.TabIndex = 11;
            // 
            // BreedLbl
            // 
            this.BreedLbl.AutoSize = true;
            this.BreedLbl.Location = new System.Drawing.Point(218, 153);
            this.BreedLbl.Name = "BreedLbl";
            this.BreedLbl.Size = new System.Drawing.Size(51, 18);
            this.BreedLbl.TabIndex = 11;
            this.BreedLbl.Text = "Breed:";
            // 
            // MoreInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._596;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 449);
            this.Controls.Add(this.panel1);
            this.Name = "MoreInformation";
            this.Text = "MoreInformation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MoreInformation_FormClosed);
            this.Load += new System.EventHandler(this.MoreInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label TypeLbl;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.Label Desc;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button CommandBtn;
        private System.Windows.Forms.Label IdLbl;
        public System.Windows.Forms.ComboBox CommandCmb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label BreedLbl;
    }
}