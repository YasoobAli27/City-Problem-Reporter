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
    public partial class form14 : Form
    {
        bool langEnglish1 = true;

        public form14(bool langEnglish)
        {
            InitializeComponent();

            langEnglish1 = langEnglish;

            if (langEnglish1 == true)
            {
                lblSurvey1.Text = "Would you recommend this software to a friend?";
                lblSurvey2.Text = "Did you find all the features you were looking for?";
                lblSurvey3.Text = "Do you plan on using this software again?";
                lblSurvey4.Text = "Check for yes / Blank for no";
                textBox1.Text = "Please enter any improvements we can make to our software";
                btnSubmit.Text = "Submit";

            }
            else
            {
                lblSurvey1.Text = "Recommanderiez-vous ce logiciel à un ami?";
                lblSurvey2.Text = "Avez-vous trouvé toutes les fonctionnalités que vous recherchiez?";
                lblSurvey3.Text = "Avez-vous l'intention d'utiliser à nouveau ce logiciel?";
                lblSurvey4.Text = "Cochez oui / videz pour non";
                textBox1.Text = "Veuillez saisir les améliorations que nous pouvons apporter à notre logiciel";
                btnSubmit.Text = "Soumettre";
            }

            checkBox1.Text = "";
            checkBox2.Text = "";
            checkBox3.Text = "";

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Main f2 = new Main(langEnglish1);
            f2.Show();
            this.Close();
        }
    }
}
