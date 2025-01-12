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
    public partial class DeleteProfSecret : Form
    {
        int failedAttemps = 0;

        bool langEnglish1 = true;

        public DeleteProfSecret(bool langEnglish)
        {
            InitializeComponent();

            langEnglish1 = langEnglish;

            if (langEnglish1 == true)
            {
                secretQPrompt.Text = "Please correctly answer the following secret questions.\nIf correct, your password will be sent to your email.";
                secretQ1.Text = "What is the first country you visited?";
                secretQ2.Text = "What is your childhood nickname?";
                secretQ3.Text = "What is your favourite food?";

                secretFinish.Text = "Finish";
                secretCancel.Text = "Cancel";
                home.Text = "Home";
            }
            else
            {
                secretQPrompt.Text = "Veuillez répondre correctement aux questions scret suivantes.\nSi correct, votre mot de passe sera envoyé à votre adresse e-mail.";
                secretQ1.Text = "Quel est le premier pays que vous avez visité?";
                secretQ2.Text = "Quel est ton surnom d'enfance?";
                secretQ3.Text = "Quelle est ta nourriture préférée?";

                secretFinish.Text = "Finir";
                secretCancel.Text = "Annuler";
                home.Text = "Domicile";
            }

        }

        private void SecretFinish_Click(object sender, EventArgs e)
        {
            if (failedAttemps == 3)
            {

                if (langEnglish1 == true)
                {
                    MessageBox.Show("3 failed attempts, you cannot delete the currently" +
                     "logged in profile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("3 tentatives infructueuses, vous ne pouvez pas supprimer le" +
                     "profil connecté", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                failedAttemps = 0;

                EditProfile log = new EditProfile(langEnglish1);
                log.Show();
                this.Hide();
            }
            else if (secretTxtbox1.Text == "Canada" &&
                secretTxtbox2.Text == "Nick" &&
                secretTxtbox3.Text == "Pizza")
            {
                if (langEnglish1 == true)
                {
                    MessageBox.Show("Success! Your currently logged in profile will be deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Succès! Votre profil actuellement connecté sera supprimé", "Succès", MessageBoxButtons.OK, MessageBoxIcon.None);
                }

                
                Home home = new Home(langEnglish1);
                home.Show();
                this.Hide();
            }
            else if (secretTxtbox1.Text == "" ||
                secretTxtbox2.Text == "" ||
                secretTxtbox3.Text == "")
            {
                if (langEnglish1 == true)
                {
                    MessageBox.Show("Please enter all required information");
                }
                else
                {
                    MessageBox.Show("Veuillez saisir toutes les informations requises");
                }

                
            }
            else if (secretTxtbox1.Text != "Canada" ||
                secretTxtbox2.Text != "Nick" ||
                secretTxtbox3.Text != "Pizza")
            {
                if (langEnglish1 == true)
                {
                    MessageBox.Show("Inccorect information, please try again");
                }
                else
                {
                    MessageBox.Show("Informations incorrectes, veuillez réessayer");
                }
                
                failedAttemps++;
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Main f2 = new Main(langEnglish1);
            f2.Show();
            this.Close();
        }

        private void SecretCancel_Click(object sender, EventArgs e)
        {
            EditProfile f2 = new EditProfile(langEnglish1);
            f2.Show();
            this.Close();
        }

        private void FaqLogin_Click(object sender, EventArgs e)
        {
            FAQ1 faq = new FAQ1(langEnglish1);
            faq.Show();
            this.Close();
        }
    }
}
