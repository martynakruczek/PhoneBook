using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class MainForm : Form
    {
        AddContact AddForm;
        ContactDetails ContactDetails;
        EditContact EditContact;
        BirthdayAlert Birthday;
        Search Search;

        public MainForm() {
            InitializeComponent();

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            if (contactList.SelectedIndex >= 0) {
           

                ComC.ContactIndex = contactList.SelectedIndex;
                EditContact = new EditContact();
                EditContact.ShowDialog();

                contactList.Items.Clear();
                ComC.IsFiltered = false;
                ComC.people = ComC.people.OrderBy(x=>x.FirstName).ToList();

                foreach (var item in ComC.people) {
                    contactList.Items.Add(item.FirstName + " " + item.LastName);

                }
            }
            else {
                AddForm = new AddContact();
                AddForm.ShowDialog();
                contactList.Items.Clear();
                ComC.IsFiltered = false;

                ComC.people = ComC.people.OrderBy(x=>x.FirstName).ToList();
                foreach (var item in ComC.people) {
                    contactList.Items.Add(item.FirstName + " " + item.LastName);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (contactList.SelectedIndex >= 0) {
                if(ComC.IsFiltered == true) {
                    ComC.ContactIndex = contactList.SelectedIndex;
                    int id = ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).Id;
                    contactList.Items.RemoveAt(ComC.ContactIndex);
                    ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower());
                    ComC.people.Remove(ComC.people.Where(x => x.Id == id).ToList().ElementAt(0));
                    
                }
                else {
                    ComC.ContactIndex = contactList.SelectedIndex;
                    contactList.Items.RemoveAt(ComC.ContactIndex);
                    ComC.people.RemoveAt(ComC.ContactIndex);
                }
            }
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {

            if(contactList.SelectedIndex >= 0) {
                ComC.ContactIndex = contactList.SelectedIndex;
                ContactDetails = new ContactDetails();
                ContactDetails.ShowDialog();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search = new Search();
            Search.ShowDialog();
            
            if (ComC.Condition != "") {
                contactList.Items.Clear();
                ComC.IsFiltered = true;
                ComC.people = ComC.people.OrderBy(x => x.FirstName).ToList();

                foreach (var item in ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower())) {
                    contactList.Items.Add(item.FirstName + " " + item.LastName);
                }
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            contactList.Items.Clear();

            ComC.IsFiltered = false;
            ComC.people = ComC.people.OrderBy(x => x.FirstName).ToList();

            foreach (var item in ComC.people) {
                contactList.Items.Add(item.FirstName +" "+ item.LastName);
            }
            foreach (var item in ComC.people) {
                if (item.BirthDate.Substring(0,1) == DateTime.Today.Day.ToString() && item.BirthDate.Substring(3,4) == DateTime.Today.Month.ToString()) {
                    Birthday = new BirthdayAlert(item);
                    Birthday.ShowDialog();
                }
            }
        }

        private void editAvatar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            avatar.ImageLocation = openFileDialog1.FileName;
            avatar.BackgroundImage = null;
            avatar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void MainForm_Load(object sender, EventArgs e) {

            contactList.Items.Clear();
            ComC.people = ComC.people.OrderBy(x => x.FirstName).ToList();

            foreach (var item in ComC.people) {
                contactList.Items.Add(item.FirstName + " " + item.LastName);

            }
            foreach (var item in ComC.people) {
                if (item.BirthDate.Substring(0, 2) == DateTime.Today.Day.ToString()){
                    Birthday = new BirthdayAlert(item);
                    Birthday.ShowDialog();
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            ComC.SaveToDB();
        }
    }
}
