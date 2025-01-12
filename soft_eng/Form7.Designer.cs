namespace soft_eng
{
    partial class TellFriend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TellFriend));
            this.tellMessage = new System.Windows.Forms.Label();
            this.tellEmailTxt = new System.Windows.Forms.TextBox();
            this.tellEmail = new System.Windows.Forms.Label();
            this.tellMessageTxt = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.faqLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tellMessage
            // 
            this.tellMessage.AutoSize = true;
            this.tellMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tellMessage.Location = new System.Drawing.Point(301, 381);
            this.tellMessage.Name = "tellMessage";
            this.tellMessage.Size = new System.Drawing.Size(840, 39);
            this.tellMessage.TabIndex = 6;
            this.tellMessage.Text = "Would you like to add a personal message? (optional)";
            // 
            // tellEmailTxt
            // 
            this.tellEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tellEmailTxt.Location = new System.Drawing.Point(308, 253);
            this.tellEmailTxt.Name = "tellEmailTxt";
            this.tellEmailTxt.Size = new System.Drawing.Size(1064, 47);
            this.tellEmailTxt.TabIndex = 5;
            // 
            // tellEmail
            // 
            this.tellEmail.AutoSize = true;
            this.tellEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tellEmail.Location = new System.Drawing.Point(313, 160);
            this.tellEmail.Name = "tellEmail";
            this.tellEmail.Size = new System.Drawing.Size(436, 39);
            this.tellEmail.TabIndex = 4;
            this.tellEmail.Text = "What is your friends email?";
            // 
            // tellMessageTxt
            // 
            this.tellMessageTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tellMessageTxt.Location = new System.Drawing.Point(308, 442);
            this.tellMessageTxt.Name = "tellMessageTxt";
            this.tellMessageTxt.Size = new System.Drawing.Size(1064, 259);
            this.tellMessageTxt.TabIndex = 9;
            this.tellMessageTxt.Text = resources.GetString("tellMessageTxt.Text");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(691, 772);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 95);
            this.button1.TabIndex = 10;
            this.button1.Text = "Spread the word!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // home
            // 
            this.home.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Location = new System.Drawing.Point(1127, 873);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(263, 64);
            this.home.TabIndex = 56;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.Home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::soft_eng.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(48, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 174);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.label3.Location = new System.Drawing.Point(26, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1392, 39);
            this.label3.TabIndex = 59;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1071, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 50);
            this.label2.TabIndex = 58;
            this.label2.Text = "City of Toronto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 50);
            this.label1.TabIndex = 57;
            this.label1.Text = "Cypress Software";
            // 
            // faqLogin
            // 
            this.faqLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.faqLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.faqLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.faqLogin.Location = new System.Drawing.Point(1427, 873);
            this.faqLogin.Name = "faqLogin";
            this.faqLogin.Size = new System.Drawing.Size(116, 64);
            this.faqLogin.TabIndex = 60;
            this.faqLogin.Text = "FAQ";
            this.faqLogin.UseVisualStyleBackColor = false;
            this.faqLogin.Click += new System.EventHandler(this.FaqLogin_Click);
            // 
            // TellFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 949);
            this.Controls.Add(this.faqLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.home);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tellMessageTxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tellMessage);
            this.Controls.Add(this.tellEmailTxt);
            this.Controls.Add(this.tellEmail);
            this.Name = "TellFriend";
            this.Text = "Tell a friend";
            this.Load += new System.EventHandler(this.TellFriend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tellMessage;
        private System.Windows.Forms.TextBox tellEmailTxt;
        private System.Windows.Forms.Label tellEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox tellMessageTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button faqLogin;
    }
}