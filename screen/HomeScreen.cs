using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sqlitedb.utilities;
using sqlitedb.services;
using sqlitedb.app_configuration;
using sqlitedb.model;
namespace sqlitedb
{
    public partial class HomeScreen : Form
    {
        PersonsServices services = new PersonsServices();
        private static PersonModel personInfo = new PersonModel();
        public HomeScreen()
        {
            InitializeComponent();

            LoadData();
        }

        private void Newbtn_Click(object sender, EventArgs e)
        {
            Nametxt.Clear();
            Phonetxt.Clear();
            Emailtxt.Clear();
        }

        private void LoadData()
        {
            try
            {

                PersonsGrid.DataSource = services.GetPersons();
                Personslbl.Text = PersonsGrid.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                Utils.handleException(ex);
            }
        }
        private void handleNewPerson()
        {
            try
            {
                PersonModel person = new PersonModel();
                person.name = Nametxt.Text.ToUpper();
                person.email = Emailtxt.Text;
                person.phone = Phonetxt.Text;
                person.id = Utils.generateOTP();
                services.AddNewPerson(person);
                LoadData();
            }
            catch (Exception ex)
            {

                Utils.handleException(ex);
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            handleNewPerson();
        }

        private void HandlePersonSelected(object sender, EventArgs e)
        {
            
        }

        private void HandleSelectedCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = PersonsGrid.Rows[e.RowIndex];
                PersonModel person = new PersonModel();
                person.id = row.Cells["id"].Value.ToString();
                person.name = row.Cells["name"].Value.ToString();
                person.phone = row.Cells["phone"].Value.ToString();
                person.email = row.Cells["email"].Value.ToString();
                Nametxt.Text = person.name;
                Phonetxt.Text = person.phone;
                Emailtxt.Text = person.email;
                personInfo = person;
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                services.UpdatePerson(personInfo);
                LoadData();
            }
            catch (Exception ex)
            {

                Utils.handleException(ex);
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(personInfo.id.Length>0&&MessageBox.Show("Do you want to remove "+personInfo.name,"Delete Person", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    services.DeletePerson(personInfo);
                    LoadData();
                }
            }
            catch (Exception ex)
            {

                Utils.handleException(ex);
            }
        }

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PersonModel model = new PersonModel();
                model.name = Searchtxt.Text;
                model.phone = Searchtxt.Text;
                model.email = Searchtxt.Text;

                PersonsGrid.DataSource = services.SearchPerson(model);

            }
            catch (Exception ex)
            {

                Utils.handleException(ex);
            }
        }

        
    }
}
