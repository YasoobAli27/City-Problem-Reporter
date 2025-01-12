using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

public enum PasswordScore
{
    Blank = 0,
    Weak = 2,
    Strong = 4
    
}

namespace soft_eng
{
    public partial class Register : Form
    {

        bool langEnglish1 = true;

        public Register(bool langEnglish)
        {
            InitializeComponent();

            langEnglish1 = langEnglish;

            if (langEnglish1 == true)
            {
                label3.Text = "-----------------------------------------------------------------------------------------------------------------------------\nPlease enter the required information below:";
                label10.Text = "First Name";
                label9.Text = "Last Name";
                label7.Text = "Address";
                label2.Text = "Phone Number";
                label8.Text = "Email Address";
                label5.Text = "Username";
                label6.Text = "Password";
                termsCheckbox.Text = "I accept the terms and contitions";
                regRegister.Text = "Register";
                regCancel.Text = "Cancel";

            }
            else
            {
                label3.Text = "-----------------------------------------------------------------------------------------------------------------------------\nVeuillez saisir les informations requises ci-dessous:";
                label10.Text = "Prénom";
                label9.Text = "Nom de Famille";
                label7.Text = "Adresse";
                label2.Text = "Numéro de téléphone";
                label8.Text = "Adresse e-mail";
                label5.Text = "Nom d'utilisateur";
                label6.Text = "Le mot de passe";
                termsCheckbox.Text = "J'accepte les termes et conditions";
                regRegister.Text = "S'inscrire";
                regCancel.Text = "Annuler";
            }

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //terms and cond.
        }

        private void RegCancel_Click(object sender, EventArgs e)
        {
            //register cancel
            Login f2 = new Login(langEnglish1);
            f2.Show();
            this.Hide();
        }

        private void RegRegister_Click(object sender, EventArgs e)
        {
            //register
            PasswordScore passwordStrengthScore = PasswordAdvisor.CheckStrength(reguserPass.Text);

            if (regFirst.Text == "" || regLast.Text == "" || regAddress.Text == "" || regPhone.Text == "" ||
                regEmail.Text == "" || regLast.Text == "" || reguserText.Text == "" || reguserPass.Text == "")
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
            else if (reguserText.Text == "admin_user")
            {
                if (langEnglish1 == true)
                {
                    MessageBox.Show("Please enter a different username, already taken");
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un nom d'utilisateur différent, déjà pris");
                }
            }
            else if (!termsCheckbox.Checked)
            {
                if (langEnglish1 == true)
                {
                    MessageBox.Show("Please accept the terms and conditions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Veuillez accepter les termes et conditions", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                switch (passwordStrengthScore)
                {
                    case PasswordScore.Blank:
                    case PasswordScore.Weak:
                        if (langEnglish1 == true)
                        {
                            MessageBox.Show("Weak password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Mot de passe faible", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    default:
                        {
                            Login log = new Login(langEnglish1);
                            log.Show();
                            this.Hide();
                            break;
                        }
                        

                        
                }
            }

        private void FaqLogin_Click(object sender, EventArgs e)
        {
            FAQ1 faq1 = new FAQ1(langEnglish1);
            faq1.Show();
            this.Hide();
        }
    }

        
    }

    public class PasswordAdvisor
    {
    //password regex from stackoverflow
        public static PasswordScore CheckStrength(string password)
        {
            int score = 0;

            if (password.Length < 1)
                return PasswordScore.Blank;
            if (password.Length < 4)
                return PasswordScore.Weak;

            if (password.Length >= 12)
                score++;
            if (Regex.Match(password, @"/\d+/", RegexOptions.ECMAScript).Success)
                score++;
            if (Regex.Match(password, @"/[a-z]/", RegexOptions.ECMAScript).Success &&
              Regex.Match(password, @"/[A-Z]/", RegexOptions.ECMAScript).Success)
                score++;
            if (Regex.Match(password, @"/.[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]/", RegexOptions.ECMAScript).Success)
                score++;
            if (score > 4)
                return PasswordScore.Strong;

            return (PasswordScore)score;
        }
    }

