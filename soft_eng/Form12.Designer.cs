namespace soft_eng
{
    partial class MainEditReport
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
            this.edit_box = new System.Windows.Forms.RichTextBox();
            this.editCancel = new System.Windows.Forms.Button();
            this.editSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edit_box
            // 
            this.edit_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_box.Location = new System.Drawing.Point(12, 12);
            this.edit_box.Name = "edit_box";
            this.edit_box.Size = new System.Drawing.Size(1341, 735);
            this.edit_box.TabIndex = 0;
            this.edit_box.Text = "";
            this.edit_box.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // editCancel
            // 
            this.editCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCancel.Location = new System.Drawing.Point(756, 765);
            this.editCancel.Name = "editCancel";
            this.editCancel.Size = new System.Drawing.Size(183, 62);
            this.editCancel.TabIndex = 19;
            this.editCancel.Text = "Cancel";
            this.editCancel.UseVisualStyleBackColor = true;
            this.editCancel.Click += new System.EventHandler(this.EditCancel_Click);
            // 
            // editSave
            // 
            this.editSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSave.Location = new System.Drawing.Point(404, 765);
            this.editSave.Name = "editSave";
            this.editSave.Size = new System.Drawing.Size(183, 62);
            this.editSave.TabIndex = 18;
            this.editSave.Text = "Finish";
            this.editSave.UseVisualStyleBackColor = true;
            this.editSave.Click += new System.EventHandler(this.EditSave_Click);
            // 
            // MainEditReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 852);
            this.Controls.Add(this.editCancel);
            this.Controls.Add(this.editSave);
            this.Controls.Add(this.edit_box);
            this.Name = "MainEditReport";
            this.Text = "Edit report";
            this.Load += new System.EventHandler(this.MainEditReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox edit_box;
        private System.Windows.Forms.Button editCancel;
        private System.Windows.Forms.Button editSave;
    }
}