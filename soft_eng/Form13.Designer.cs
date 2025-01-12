
namespace soft_eng
{
    partial class ContactPage
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
            this.listViewPeople = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDistrict = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.pageInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewPeople
            // 
            this.listViewPeople.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnDistrict});
            this.listViewPeople.FullRowSelect = true;
            this.listViewPeople.GridLines = true;
            this.listViewPeople.HideSelection = false;
            this.listViewPeople.Location = new System.Drawing.Point(53, 237);
            this.listViewPeople.Name = "listViewPeople";
            this.listViewPeople.Size = new System.Drawing.Size(1726, 674);
            this.listViewPeople.TabIndex = 0;
            this.listViewPeople.UseCompatibleStateImageBehavior = false;
            this.listViewPeople.View = System.Windows.Forms.View.Details;
            this.listViewPeople.SelectedIndexChanged += new System.EventHandler(this.listViewPeople_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 572;
            // 
            // columnDistrict
            // 
            this.columnDistrict.Text = "District";
            this.columnDistrict.Width = 600;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 75);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cypress Software";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(747, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 75);
            this.label2.TabIndex = 6;
            this.label2.Text = "City of Toronto";
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(1590, 953);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(189, 75);
            this.homeButton.TabIndex = 7;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // pageInfo
            // 
            this.pageInfo.AutoSize = true;
            this.pageInfo.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.pageInfo.Location = new System.Drawing.Point(18, 89);
            this.pageInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pageInfo.Name = "pageInfo";
            this.pageInfo.Size = new System.Drawing.Size(1912, 114);
            this.pageInfo.TabIndex = 8;
            this.pageInfo.Text = "---------------------------------------------------------------------------------" +
    "------------------------------\r\nContact Us";
            // 
            // ContactPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.pageInfo);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewPeople);
            this.Name = "ContactPage";
            this.Text = "Contact Page";
            this.Load += new System.EventHandler(this.ContactPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPeople;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDistrict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label pageInfo;
    }
}