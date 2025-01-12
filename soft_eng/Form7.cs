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
    public partial class TellFriend : Form
    {
        bool langEnglish1 = true;

        public TellFriend(bool langEnglish)
        {
            InitializeComponent();

            langEnglish1 = langEnglish;

            if (langEnglish1 == true)
            {
                tellEmail.Text = "What is your friend's email?";
                tellMessage.Text = "Would you like to add a personal message? (optional)";
                tellMessageTxt.Text = "Hey, check out this useful application! You can report issues that arise within our city \nand stay informed of problems reporrted by others.\n\nSpread the word! The more people that report the more our city will thrive!";

                button1.Text = "Spread the word!";
                home.Text = "Home";
            }
            else
            {
                tellEmail.Text = "Quelle est l'e-mail de votre ami?";
                tellMessage.Text = "Souhaitez-vous ajouter un message personnel? (optionnel)";
                tellMessageTxt.Text = "Hé, consultez cette application utile! Vous pouvez signaler les problèmes qui surviennent\ndans notre ville et rester informé des problèmes répétés par d'autres.\nPlus il y a de gens qui rapportent, plus notre ville prospérera!";

                button1.Text = "Faire connaitre!";
                home.Text = "Domicile";
            }

        }

        private void TellFriend_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (tellMessageTxt.Text == "")
            {
                if (langEnglish1 == true)
                {
                    tellMessageTxt.Text = "Hey, check out this useful application! You can report issues that arise within our city \nand stay informed of problems reporrted by others.\n\nSpread the word! The more people that report the more our city will thrive!";
                }
                else
                {
                    tellMessageTxt.Text = "Hé, consultez cette application utile! Vous pouvez signaler les problèmes qui surviennent\ndans notre ville et rester informé des problèmes répétés par d'autres.\nPlus il y a de gens qui rapportent, plus notre ville prospérera!";
                }
            }
            Home btn = new Home(langEnglish1);
            btn.Show();
            this.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Main f2 = new Main(langEnglish1);
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
