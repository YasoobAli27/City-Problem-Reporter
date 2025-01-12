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
    public partial class FAQ2 : Form
    {
        bool langEnglish1 = true;

        public FAQ2(bool langEnglish)
        {
            InitializeComponent();

            langEnglish1 = langEnglish;

            if (langEnglish1 == true)
            {
                pageInfo.Text = "FAQ Page 2";
                question1.Text = "How do I report a problem?";
                answer2.Text = "From the Quick Links page, select report a problem\nand then write down the address and choose your problem.";
                label1.Text = "How do I vote for an existing problem?";
                label2.Text = "From the Quick Links page, select Vote\nand then click on the problem that you would like to vote for.";

                returnBtn.Text = "Return";
                home.Text = "Home";
                prevBtn.Text = "< Previous";

            }
            else
            {
                pageInfo.Text = "FAQ Page 2";
                question1.Text = "Comment signaler un problème?";
                answer2.Text = "À partir de la page Liens rapides, sélectionnez signaler\npuis notez l'adresse et choisissez votre problème.";
                label1.Text = "Comment voter pour un problème existant?";
                label2.Text = "À partir de la page Liens rapides, sélectionnez Informations\npuis cliquez sur le problème pour lequel vous souhaitez voter.";

                returnBtn.Text = "Revenir";
                home.Text = "Domicile";
                prevBtn.Text = "< Précédent";

            }

        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            //go to previous page and close current
            FAQ1 faq1 = new FAQ1(langEnglish1);
            faq1.Show();
            this.Close();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FAQ2_Load(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Main f2 = new Main(langEnglish1);
            f2.Show();
            this.Close();
        }
    }
}
