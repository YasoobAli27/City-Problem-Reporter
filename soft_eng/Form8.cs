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
    public partial class FAQ1 : Form
    {
        bool langEnglish1 = true;

        public FAQ1(bool langEnglish)
        {
            InitializeComponent();

            langEnglish1 = langEnglish;
            
            if (langEnglish1 == true)
            {
                pageInfo.Text = "FAQ page 1";
                question1.Text = "How can I create an account?";
                answer1.Text = "To create an account, select Register from the login screen.\nFrom there, enter your first and last name, address, phone number, email, desired username and password.\nNext click I accept the terms and conditions, and select Register.\nNote: your password must be strong enough in order to register.";
                question2.Text = "I forgot my password. How can I restore it?";
                answer2.Text = "From the login screen, select Forgot password and\nfollow the instructions on that page.";

                returnBtn.Text = "Return";
                home.Text = "Home";
                nextBtn.Text = "Next >";

            }    
            else
            {
                pageInfo.Text = "FAQ page 1";
                question1.Text = "Comment puis-je créer un compte?";
                answer1.Text = "Pour créer un compte, sélectionnez S'inscrire dans l'écran de\nconnexion. À partir de là, entrez vos nom et prénom, adresse, numéro de téléphone, e-mail,\nnom d'utilisateur et mot de passe souhaités. Cliquez ensuite sur J'accepte\nles termes et conditions, puis sélectionnez S'inscrire. le mot de passe doit\nêtre suffisamment fort pour pouvoir s'inscrire.";
                question2.Text = "J'ai oublié mon mot de passe. Comment puis-je le restaurer?";
                answer2.Text = "À partir de l'écran de connexion, sélectionnez Mot de passe\noublié et suivez les instructions sur cette page";

                returnBtn.Text = "Revenir";
                home.Text = "Domicile";
                nextBtn.Text = "Suivant >";

            }

        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            //go to next page and close current
            FAQ2 faq2 = new FAQ2(langEnglish1);
            faq2.Show();
            this.Close();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Main f2 = new Main(langEnglish1);
            f2.Show();
            this.Close();
        }

        private void FAQ1_Load(object sender, EventArgs e)
        {

        }
    }
}
