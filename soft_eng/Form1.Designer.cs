namespace soft_eng
{
    partial class Home
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
            this.CypressTitle = new System.Windows.Forms.Label();
            this.EnglishBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FrenchBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FaqHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CypressTitle
            // 
            this.CypressTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CypressTitle.AutoSize = true;
            this.CypressTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 95F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CypressTitle.Location = new System.Drawing.Point(400, 47);
            this.CypressTitle.Name = "CypressTitle";
            this.CypressTitle.Size = new System.Drawing.Size(676, 144);
            this.CypressTitle.TabIndex = 0;
            this.CypressTitle.Text = "CYPRESS";
            this.CypressTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnglishBtn
            // 
            this.EnglishBtn.AutoSize = true;
            this.EnglishBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EnglishBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.EnglishBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EnglishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.EnglishBtn.Location = new System.Drawing.Point(463, 645);
            this.EnglishBtn.Name = "EnglishBtn";
            this.EnglishBtn.Size = new System.Drawing.Size(168, 56);
            this.EnglishBtn.TabIndex = 1;
            this.EnglishBtn.Text = "English";
            this.EnglishBtn.UseVisualStyleBackColor = false;
            this.EnglishBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(556, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 63);
            this.label2.TabIndex = 2;
            this.label2.Text = "City of Toronto";
            // 
            // FrenchBtn
            // 
            this.FrenchBtn.AutoSize = true;
            this.FrenchBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FrenchBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FrenchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.FrenchBtn.Location = new System.Drawing.Point(851, 645);
            this.FrenchBtn.Name = "FrenchBtn";
            this.FrenchBtn.Size = new System.Drawing.Size(160, 56);
            this.FrenchBtn.TabIndex = 3;
            this.FrenchBtn.Text = "French";
            this.FrenchBtn.UseVisualStyleBackColor = false;
            this.FrenchBtn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::soft_eng.Properties.Resources.city_tor_sign;
            this.pictureBox1.Location = new System.Drawing.Point(593, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // FaqHome
            // 
            this.FaqHome.AutoSize = true;
            this.FaqHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FaqHome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FaqHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.FaqHome.Location = new System.Drawing.Point(1377, 845);
            this.FaqHome.Name = "FaqHome";
            this.FaqHome.Size = new System.Drawing.Size(100, 49);
            this.FaqHome.TabIndex = 5;
            this.FaqHome.Text = "FAQ";
            this.FaqHome.UseVisualStyleBackColor = false;
            this.FaqHome.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1489, 906);
            this.Controls.Add(this.FaqHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FrenchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnglishBtn);
            this.Controls.Add(this.CypressTitle);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Home";
            this.Text = "Cypress Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CypressTitle;
        private System.Windows.Forms.Button EnglishBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FrenchBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FaqHome;
    }
}

