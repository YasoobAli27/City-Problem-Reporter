using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace soft_eng
{
    public partial class MainEditReport : Form
    {
        bool langEnglish1 = true;

        public MainEditReport(bool langEnglish)
        {
            InitializeComponent();

            langEnglish1 = langEnglish;
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public override string Text { get; set; }
        private void MainEditReport_Load(object sender, EventArgs e)
        {
            var path = @"C:\CPS 406\Version 4\data.txt";
            string s = "";
            string report = "";
            using (StreamReader sr = File.OpenText(path))
            {
                

                while ((s = sr.ReadLine()) != null)
                {
                    report += s + "\n";
                }
            }
            // Creating RichTextBox using RichTextBox class constructor
            //RichTextBox edit_box = new RichTextBox();

            // Adding text in the control box
            edit_box.Text = report;
            //edit_box.Text = "!..Welcome to GeeksforGeeks..!";

            // Add this RichTextBox to the form
            this.Controls.Add(edit_box);
        }

        private void EditCancel_Click(object sender, EventArgs e)
        {
            Main f1 = new Main(langEnglish1);
            f1.Show();
            this.Close();
        }

        private void EditSave_Click(object sender, EventArgs e)
        {
            Main f1 = new Main(langEnglish1);
            f1.Show();
            this.Close();
        }
    }
}
