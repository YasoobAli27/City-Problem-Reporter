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

    public partial class Login : Form
    {
        int failedAttemps = 0;
        bool lockedOut = false;

        bool langEnglish1 = true;

        public Login(bool langEnglish)
        {
            InitializeComponent();

            langEnglish1 = langEnglish;

            if (langEnglish1 == true)
            {
                label2.Text = "City Of Toronto";
                label3.Text = "-----------------------------------------------------------------------------------------------------------------------------\nYou are currenty on the cypress logging page. By logging into this system you will be able to report\na variety of problems as you have witnessed on the streets of Toronto.";
                label5.Text = "Username";
                label6.Text = "Password";
                label7.Text = "New user? Click register\nto create a new account.";
                loginBtn.Text = "Login";
                forgotPassBtn.Text = "Forgot";
                registerBtn.Text = "Register";
                cancelBtn.Text = "Cancel";
                // FAQ button left unchanged

            }
            else
            {
                label2.Text = "Ville de Toronto";
                label3.Text = "-----------------------------------------------------------------------------------------------------------------------------\nVous êtes actuellement sur la page d'enregistrement de cyprès. En vous connectant à ce système,\nvous serez en mesure de signaler une variété de problèmes comme vous\nen avez été témoins dans les rues de Toronto.";
                label5.Text = "Nom d'utilisateur";
                label6.Text = "Le mot de passe";
                label7.Text = "Nouvel utilisateur?\nCliquez sur S'inscrire\npour créer un nouveau compte";
                loginBtn.Text = "connexion";
                forgotPassBtn.Text = "Oublié";
                registerBtn.Text = "S'inscrire";
                cancelBtn.Text = "Annuler";
                // FAQ button left unchanged
            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //login
            if(lockedOut)
            {
                loginBtn.Enabled = false;

                // Save data to database
                //...
                System.Threading.Thread.Sleep(5000);
                Application.DoEvents();   // Empty the message queue
                if (!loginBtn.IsDisposed)
                {
                    loginBtn.Enabled = true;
                    lockedOut = false;
                }
            }
            else if(failedAttemps == 3)
            {
                if (langEnglish1 == true)
                {
                    MessageBox.Show("3 failed password attempts, you have been locked out for an hour", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("3 tentatives de mot de passe infructueuses, vous avez été verrouillé pendant une heure", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                failedAttemps = 0;
                lockedOut = true;

            }
            else if(userText.Text == "" || userPass.Text == "")
            {

                if (langEnglish1 == true)
                {
                    MessageBox.Show("Please enter username and password");
                }
                else
                {
                    MessageBox.Show("Veuillez entrer votre nom d'utilisateur et votre mot de passe");
                }
            }
            else if (userText.Text == "admin_user" && userPass.Text == "admin_pass")
            {
            Main f5 = new Main(langEnglish1);
            f5.Show();
            this.Hide();
            }
            else if(userText.Text == "admin_user")
            {
                if (langEnglish1 == true)
                {
                    MessageBox.Show("inncorect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                failedAttemps++;
            }
            else
            {
                if (langEnglish1 == true)
                {
                    MessageBox.Show("Username/password not found in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur / mot de passe introuvable dans la base de données", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //forgot password
            SecretQ f4 = new SecretQ(langEnglish1);
            f4.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {   
            //register
            Register f3 = new Register(langEnglish1);
            f3.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //cancel
            Home hm = new Home(langEnglish1);
            hm.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //faq
            FAQ1 faq1 = new FAQ1(langEnglish1);
            faq1.Show();
            this.Hide();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //username text field

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            //password text field
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
