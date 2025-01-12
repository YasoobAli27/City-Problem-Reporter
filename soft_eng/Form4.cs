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
    public partial class SecretQ : Form
    {
        int failedAttemps = 0;

        bool langEnglish1 = true;

        public SecretQ(bool langEnglish)
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
            }
            else
            {
                secretQPrompt.Text = "Veuillez répondre correctement aux questions secrètes suivantes.\nSi correct, votre mot de passe sera envoyé à votre adresse e-mail.";
                secretQ1.Text = "Quel est le premier pays que vous avez visité?";
                secretQ2.Text = "Quel est ton surnom d'enfance?";
                secretQ3.Text = "Quelle est ta nourriture préférée?";
                secretFinish.Text = "Finir";
                secretCancel.Text = "Annuler";
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void SecretTxtbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecretTxtbox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SecretTxtbox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecretCancel_Click(object sender, EventArgs e)
        {
            Login btn = new Login(langEnglish1);
            btn.Show();
            this.Hide();
        }

        private void SecretFinish_Click(object sender, EventArgs e)
        {
            if (failedAttemps == 3)
            {
                if (langEnglish1 == true)
                {
                    MessageBox.Show("3 failed attempts, a link will be sent to your email for further verification", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("3 tentatives de mot de passe infructueuses, vous avez été verrouillé pendant une heure", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                failedAttemps = 0;

                Login log = new Login(langEnglish1);
                log.Show();
                this.Hide();
            }
            else if (secretTxtbox1.Text == "Canada" &&
                secretTxtbox2.Text == "Nick" &&
                secretTxtbox3.Text == "Pizza")
            {
                if (langEnglish1 == true)
                {
                    MessageBox.Show("Success! Your password will be sent to your email shortly", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Succès! Votre mot de passe sera envoyé à votre adresse e-mail sous peu", "Succès", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                Login btn = new Login(langEnglish1);
                btn.Show();
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

        private void SecretQPrompt_Click(object sender, EventArgs e)
        {

        }

        private void SecretQ3_Click(object sender, EventArgs e)
        {

        }

        private void SecretQ2_Click(object sender, EventArgs e)
        {

        }

        private void SecretQ1_Click(object sender, EventArgs e)
        {

        }

        private void FaqLogin_Click(object sender, EventArgs e)
        {
            FAQ1 faq1 = new FAQ1(langEnglish1);
            faq1.Show();
            this.Hide();
        }
    }
}
