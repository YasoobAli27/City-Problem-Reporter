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
    public partial class Main : Form
    {

        bool langEnglish1 = true;

        public Main(bool langEnglish)
        {
            InitializeComponent();

            langEnglish1 = langEnglish;

            if (langEnglish1 == true)
            {
                label3.Text = "-----------------------------------------------------------------------------------------------------------------------------\nQuick Links >>> ";
                mainEditProf.Text = "Edit/Delete Profile";
                mainLogin.Text = "Login";
                mainReg.Text = "Register";
                mainReport.Text = "Report a problem";
                mainEditReport.Text = "Edit Report";
                mainSuggest.Text = "Suggest";
                mainVote.Text = "Vote";
                mainFaq.Text = "FAQ";
                mainContact.Text = "Contact Us";
                label4.Text = "Keeping our city streets safe and clean.\nThe world in one city.";

                mainGo.Text = "Go";
                logOut.Text = "Log Out";
                tellFriendBtn.Text = "Tell a Friend!";
            }
            else
            {
                label3.Text = "-----------------------------------------------------------------------------------------------------------------------------\nLiens rapides >>> ";
                mainEditProf.Text = "Modifier / Supprimer le profil";
                mainLogin.Text = "Connexion";
                mainReg.Text = "S'inscrire";
                mainReport.Text = "Signaler un problème";
                mainEditReport.Text = "Modifier le rapport";
                mainSuggest.Text = "Suggérer";
                mainVote.Text = "Vote";
                mainFaq.Text = "FAQ";
                mainContact.Text = "Contactez-nous";
                label4.Text = "Assurer la sécurité et la propreté des rues de notre\nville.Le monde dans une seule ville.";

                mainGo.Text = "Va";
                logOut.Text = "Se déconnecter";
                tellFriendBtn.Text = "Dire à un ami!";
            }

        }

        private void MainGo_Click(object sender, EventArgs e)
        {
            if (mainEditProf.Checked)
            {
                
                EditProfile editProfile = new EditProfile(langEnglish1);
                editProfile.Show();
                this.Close();
            }
            
            if (mainLogin.Checked) {
                Login log = new Login(langEnglish1);
                log.Show();
                this.Close();
            }

            if (mainReg.Checked)
            {
                Register reg = new Register(langEnglish1);
                reg.Show();
                this.Close();
            }
            //report page
            if (mainReport.Checked)
            {
                ReportPage rep = new ReportPage(langEnglish1);
                rep.Show();
                this.Close();
            }
            //edit report
            if (mainEditReport.Checked)
            {
                MainEditReport rep = new MainEditReport(langEnglish1);
                rep.Show();
                this.Close();
            }
            //suggest page

            if (mainSuggest.Checked)
            {
                form14 rep = new form14(langEnglish1);
                rep.Show();
                this.Close();

            }

            //vote page

            //faq
            if (mainFaq.Checked)
            {
                FAQ1 faq = new FAQ1(langEnglish1);
                faq.Show();
                this.Close();
            }
            //contact us
            if (mainContact.Checked)
            {
                ContactPage contact = new ContactPage(langEnglish1);
                contact.Show();
                this.Close();
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Home f2 = new Home(langEnglish1);
            f2.Show();
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void tellFriendBtn_Click(object sender, EventArgs e)
        {
            TellFriend rep = new TellFriend(langEnglish1);
            rep.Show();
            this.Close();
        }
    }
}
