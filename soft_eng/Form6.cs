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
    public partial class EditProfile : Form
    {
        bool langEnglish1 = true;

        public EditProfile(bool langEnglish)
        {
            InitializeComponent();

            langEnglish1 = langEnglish;

            if (langEnglish1 == true)
            {
                label3.Text = "-----------------------------------------------------------------------------------------------------------------------------\nEdit desired information, then click accept.Or delete profile if you would like to delete your current\nprofile logged in.";
                editFirst.Text = "First Name";
                editLast.Text = "Last Name";
                editAddress.Text = "Address";
                editPhone.Text = "Phone Number";
                editEmail.Text = "Email Address";
                editUser.Text = "Username";
                editPass.Text = "Password";

                editAccept.Text = "Accept";
                editDelete.Text = "Delete";
                editCancel.Text = "Cancel";
                home.Text = "Home";
            }
            else
            {
                label3.Text = "-----------------------------------------------------------------------------------------------------------------------------\nModifiez les informations souhaitées, puis cliquez sur Accepter ou sur Supprimer le profil si vous\nsouhaitez supprimer votre profil actuel connecté.";
                editFirst.Text = "Prénom";
                editLast.Text = "Nom de famille";
                editAddress.Text = "Adresse";
                editPhone.Text = "Numéro de téléphone";
                editEmail.Text = "Adresse e-mail";
                editUser.Text = "Nom d'utilisateur";
                editPass.Text = "Mot de passe";

                editAccept.Text = "J'accepte";
                editDelete.Text = "Effacer";
                editCancel.Text = "Annuler";
                home.Text = "Domicile";

            }
        }

        private void EditAccept_Click(object sender, EventArgs e)
        {
            if (editFirstTxt.Text == "" || editLastTxt.Text == "" || editAddressTxt.Text == "" ||
                editPhoneTxt.Text == "" || editEmailTxt.Text == "" || editUserTxt.Text == "" || 
                editPassTxt.Text == "")
            {
                if (langEnglish1 == true)
                {
                    MessageBox.Show("Missing information, please enter all required information");
                }
                else
                {
                    MessageBox.Show("Informations manquantes, veuillez saisir toutes les informations requises");
                }
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to save the changes?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Main log = new Main(langEnglish1);
                log.Show();
                this.Hide();
            }
         
            //must add way to send email
            
        }

        private void EditCancel_Click(object sender, EventArgs e)
        {
            Main log = new Main(langEnglish1);
            log.Show();
            this.Hide();
        }

        private void EditDelete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete your " +
                "currently logged in profile?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteProfSecret form = new DeleteProfSecret(langEnglish1);
                form.Show();
                this.Hide();
                
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Main f2 = new Main(langEnglish1);
            f2.Show();
            this.Close();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {

        }

        private void FaqLogin_Click(object sender, EventArgs e)
        {
            FAQ1 faq = new FAQ1(langEnglish1);
            faq.Show();
            this.Close();
        }
    }
}
