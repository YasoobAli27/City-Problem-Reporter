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
    public partial class ContactPage : Form
    {
        bool langEnglish1 = true;

        public ContactPage(bool langEnglish)
        {
            InitializeComponent();

            langEnglish1 = langEnglish;

            if (langEnglish1 == true)
            {
                pageInfo.Text = "Contact Us";
                homeButton.Text = "Home";
            }
            else
            {
                pageInfo.Text = "Contactez-nous";
                homeButton.Text = "Domicile";
            }
        }

        private void ContactPage_Load(object sender, EventArgs e)
        {
            var people = GetPeopleList();
            // clear the list view
            listViewPeople.Items.Clear();
            foreach (var person in people)
            {
                var row = new string[] { person.Name, person.District };
                var lvi = new ListViewItem(row);
                // we add the whole object to the Tag property if we want
                // later to display details about the selected item
                lvi.Tag = person; // we need to cast to Person when we get the value
                // add the item to the list view control
                listViewPeople.Items.Add(lvi);
            }
        }

        private List<Person> GetPeopleList()
        {
            var list = new List<Person>();
            list.Add(new Person() { Name = "Councillor Michael Ford", District = "Etobicoke North", PhoneNumber = "416-397-9255", Email = " councillor_mford@toronto.ca", OfficeHours = "Wednesday 2:00 p.m. - 3:00 p.m." });
            list.Add(new Person() { Name = "Councillor Stephen Holyday", District = "Etobicoke Centre", PhoneNumber = "416-392-4002", Email = "councillor_holyday@toronto.ca", OfficeHours = "Tuesday 1:00 p.m. - 2:00 p.m."  });
            list.Add(new Person() { Name = "Councillor Mark Grimes", District = "Etobicoke-Lakeshore", PhoneNumber = "416-397-9273", Email = "councillor_grimes@toronto.ca", OfficeHours = "Monday 11:00 a.m. - 12:00 p.m." });
            list.Add(new Person() { Name = "Councillor Gord Perks", District = "Parkdale-High Park", PhoneNumber = "416-392-7919", Email = "councillor_perks@toronto.ca", OfficeHours = "Thursday 3:00 p.m. - 4:00 p.m." });
            list.Add(new Person() { Name = "Councillor Frances Nunziata", District = "York South-Weston", PhoneNumber = "416-392-4091", Email = "councillor_nunziata@toronto.ca", OfficeHours = "Friday 2:00 p.m. - 3:00 p.m." });
            list.Add(new Person() { Name = "Councillor James Pasternak", District = "York Centre", PhoneNumber = "416-392-1371", Email = "councillor_pasternak@toronto.ca", OfficeHours = "Wednesday 3:00 p.m. - 4:00 p.m." });
            list.Add(new Person() { Name = "Councillor Anthony Perruzza", District = "Humber River-Black Creek", PhoneNumber = "416-338-5335", Email = " councillor_perruzza@toronto.ca", OfficeHours = "Monday 1:00 p.m. - 2:00 p.m." });
            list.Add(new Person() { Name = "Councillor Mike Colle", District = "Eglinton-Lawrence", PhoneNumber = "416-338-2500", Email = "councillor_colle8@toronto.ca", OfficeHours = "Tuesday 11:00 a.m. - 12:00 p.m." });
            list.Add(new Person() { Name = "Councillor Ana Bailão", District = "Davenport", PhoneNumber = "416-392-7012", Email = "councillor_bailao@toronto.ca", OfficeHours = "Wednesday 1:00 p.m. - 2:00 p.m." });
            list.Add(new Person() { Name = "Councillor Joe Cressy", District = "Spadina-Fort York", PhoneNumber = "416-392-4044", Email = "councillor_cressy@toronto.ca", OfficeHours = "Thursday 11:00 a.m. - 12:00 p.m." });
            list.Add(new Person() { Name = "Councillor Mike Layton", District = "University-Rosedale", PhoneNumber = "416-392-4009", Email = "councillor_layton@toronto.ca", OfficeHours = "Friday 1:00 p.m. - 2:00 p.m." });
            list.Add(new Person() { Name = "Councillor Josh Matlow", District = "Toronto-St. Paul's", PhoneNumber = "416-392-7906", Email = "councillor_matlow@toronto.ca", OfficeHours = "Monday 2:00 p.m. - 3:00 p.m." });
            list.Add(new Person() { Name = "Councillor Kristyn Wong-Tam", District = "Toronto Centre", PhoneNumber = " 416-392-7903", Email = "councillor_wongtam@toronto.ca", OfficeHours = "Tuesday 2:00 p.m. - 3:00 p.m." });
            list.Add(new Person() { Name = "Councillor Paula Fletcher", District = "Toronto-Danforth", PhoneNumber = "416-392-4060", Email = "councillor_fletcher@toronto.ca", OfficeHours = "Wednesday 2:00 p.m. - 3:00 p.m." });
            list.Add(new Person() { Name = "Councillor Jaye Robinson", District = "Don Valley West", PhoneNumber = "416-395-6408", Email = "councillor_robinson@toronto.ca", OfficeHours = "Thursday 1:00 p.m. - 2:00 p.m." });
            list.Add(new Person() { Name = "Councillor Denzil Minnan-Wong", District = "Don Valley East", PhoneNumber = "416-397-9256", Email = "councillor_minnan-wong@toronto.ca", OfficeHours = "Friday 3:00 p.m. - 4:00 p.m." });
            list.Add(new Person() { Name = "Councillor Shelley Carroll", District = "Don Valley North", PhoneNumber = "416-338-2650", Email = "councillor_carroll@toronto.ca", OfficeHours = "Monday 3:00 p.m. - 4:00 p.m." });
            list.Add(new Person() { Name = "Councillor John Filion", District = "Willowdale", PhoneNumber = "416-392-0210", Email = "councillor_filion@toronto.ca", OfficeHours = "Tuesday 3:00 p.m. - 4:00 p.m." });
            list.Add(new Person() { Name = "Councillor Brad Bradford", District = "Beaches-East York", PhoneNumber = "416-338-2755", Email = "councillor_bradford@toronto.ca", OfficeHours = "Wednesday 1:00 p.m. - 2:00 p.m." });
            list.Add(new Person() { Name = "Councillor Gary Crawford", District = "Scarborough Southwest", PhoneNumber = "416-392-4052", Email = "councillor_crawford@toronto.ca", OfficeHours = "Thursday 11:00 a.m. - 12:00 p.m." });
            list.Add(new Person() { Name = "Councillor Michael Thompson", District = "Scarborough Centre", PhoneNumber = "416-397-9274", Email = "councillor_thompson@toronto.ca", OfficeHours = "Friday 11:00 a.m. - 12:00 p.m." });
            list.Add(new Person() { Name = "Councillor Nick Mantas", District = "Scarborough-Agincourt", PhoneNumber = "416-392-1374", Email = "Councillor_Mantas@toronto.ca", OfficeHours = "Monday 2:00 p.m. - 3:00 p.m." });
            list.Add(new Person() { Name = "Councillor Cynthia Lai", District = "Scarborough North", PhoneNumber = "416-338-2858", Email = "councillor_lai@toronto.ca", OfficeHours = "Tuesday 1:00 p.m. - 2:00 p.m." });
            list.Add(new Person() { Name = "Councillor Paul Ainslie", District = "Scarborough-Guildwood", PhoneNumber = "416-392-4008", Email = "councillor_ainslie@toronto.ca", OfficeHours = "Wednesday 11:00 a.m. - 12:00 p.m." });
            list.Add(new Person() { Name = "Councillor Jennifer McKelvie", District = "Scarborough-Rouge Park", PhoneNumber = "416-338-3771", Email = "councillor_mckelvie@toronto.ca", OfficeHours = "Thursday 1:00 p.m. - 2:00 p.m." });
            return list;
        }

        private void listViewPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (Person)listViewPeople.SelectedItems[0].Tag;

                if (selectedItem != null)
                {
                    MessageBox.Show(selectedItem.ToString(), "Contact Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Main home = new Main(langEnglish1);
            home.Show();
            this.Close();
        }
    }
}
