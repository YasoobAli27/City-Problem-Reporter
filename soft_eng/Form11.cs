using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace soft_eng
{
    public partial class ReportPage : Form
    {
        bool langEnglish1 = true;

        public ReportPage(bool langEnglish)
        {
            InitializeComponent();

            langEnglish1 = langEnglish;

            if (langEnglish1 == true)
            {
                secretQPrompt.Text = "Address";
                label4.Text = "PROBLEMS AT THE SITE -->\n---------------------------------------------------------------------------------------------------------------------------- -\n";
                p1.Text = "Utility failures";
                p2.Text = "Potholes";
                p3.Text = "Property vandalism";
                p4.Text = "Eroded streets";
                p5.Text = "Tree collapse";
                p6.Text = "Flooded streets";
                p7.Text = "Mold & spore growth";
                p8.Text = "Garbage or road blockage";

                reportBtn.Text = "Report";
                reportCancel.Text = "Cancel";
                home.Text = "Home";

            }
            else
            {
                secretQPrompt.Text = "Adresse";
                label4.Text = "PROBLÈMES SUR LE SITE -->\n---------------------------------------------------------------------------------------------------------------------------- -\n";
                p1.Text = "Pannes des services publics";
                p2.Text = "Nids-de-poule";
                p3.Text = "Vandalisme de propriété";
                p4.Text = "Rues érodées";
                p5.Text = "Effondrement de l'arbre";
                p6.Text = "Rues inondées";
                p7.Text = "Croissance des moisissures et des spores";
                p8.Text = "Ordures ou blocage de la route";

                reportBtn.Text = "Signaler";
                reportCancel.Text = "Annuler";
                home.Text = "Domicile";

            }

        }

        private void FaqLogin_Click(object sender, EventArgs e)
        {
            FAQ1 faq = new FAQ1(langEnglish1);
            faq.Show();
            this.Close();
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            var path = @"C:\CPS 406\Version 4\data.txt";

            if (addressBox.Text != "" && (p1.Checked || p2.Checked || p3.Checked || p4.Checked
                || p5.Checked || p6.Checked || p7.Checked || p8.Checked))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(addressBox.Text);
                    if (p1.Checked)
                    {
                        sw.WriteLine("Utility failures");
                    }
                    if (p2.Checked)
                    {
                        sw.WriteLine("Potholes");
                    }

                    sw.WriteLine("0 likes");
                    sw.WriteLine("----------------------------");
                }
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                Main main = new Main(langEnglish1);
                main.Show();
                this.Close();
            }
            else
            {
                if (langEnglish1 == true)
                {
                    MessageBox.Show("Please enter/select all required information");
                }   
                else
                {
                    MessageBox.Show("Veuillez saisir / sélectionner toutes les informations requises");
                }
                
            }
           
        }

        private void SecretTxtbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReportCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
