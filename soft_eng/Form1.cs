using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soft_eng
{
    public partial class Home : Form
    {
        bool langEnglish = true;

        public Home(bool langEnglish1)
        {

            InitializeComponent();

            langEnglish = langEnglish1;

            if (langEnglish1 == true)
            {
                label2.Text = "City Of Toronto";
                EnglishBtn.Text = "English";
                FrenchBtn.Text = "French";
            }
            else
            {
                label2.Text = "Ville de Toronto";
                EnglishBtn.Text = "Anglais";
                FrenchBtn.Text = "Français";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //english
            langEnglish = true;
            Login f2 = new Login(langEnglish);
            f2.Show();
            this.Close();
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            //french
            
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr");
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Login));
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls);

            langEnglish = false;
            Login log = new Login(langEnglish);
            log.Show();
            this.Hide();
        }
        private void applyResources(ComponentResourceManager resources, Control.ControlCollection ctls)
        {
            foreach (Control ctl in ctls)
            {
                resources.ApplyResources(ctl, ctl.Name);
                applyResources(resources, ctl.Controls);
            }
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //faq
            FAQ1 faq1 = new FAQ1(langEnglish);
            faq1.Show();
            this.Hide();
        }
    }
}
