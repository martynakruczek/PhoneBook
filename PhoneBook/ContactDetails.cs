using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class ContactDetails : Form
    {
        public ContactDetails() {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label11_Click(object sender, EventArgs e) {

        }

        private void Form4_Load(object sender, EventArgs e) {

            if (ComC.IsFiltered == true) {

                firstName.Text = ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).FirstName;
                lastName.Text = ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).LastName;
                phoneNumber.Text = ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).PhoneNumber;
                email.Text = ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).Email;
                birthDate.Text = ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).BirthDate.ToShortDateString();
                street.Text = ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).Street;
                postalCode.Text = ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).PostalCode;
                city.Text = ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).City;
                contactAvatar.ImageLocation = ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).Avatar;
                contactAvatar.BackgroundImage = null;
                contactAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else {
                firstName.Text = ComC.people.ElementAt(ComC.ContactIndex).FirstName;
                lastName.Text = ComC.people.ElementAt(ComC.ContactIndex).LastName;
                phoneNumber.Text = ComC.people.ElementAt(ComC.ContactIndex).PhoneNumber;
                email.Text = ComC.people.ElementAt(ComC.ContactIndex).Email;
                birthDate.Text = ComC.people.ElementAt(ComC.ContactIndex).BirthDate.ToShortDateString();
                street.Text = ComC.people.ElementAt(ComC.ContactIndex).Street;
                postalCode.Text = ComC.people.ElementAt(ComC.ContactIndex).PostalCode;
                city.Text = ComC.people.ElementAt(ComC.ContactIndex).City;
                contactAvatar.ImageLocation = ComC.people.ElementAt(ComC.ContactIndex).Avatar;
                contactAvatar.BackgroundImage = null;
                contactAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            }


            if (lastName.Text == "" || lastName.Text == "                                                  ") {
                label1.Text = "";
            }
            if (phoneNumber.Text == "+" || phoneNumber.Text == "+                                                 ") {
                label3.Text = "";
                phoneNumber.Text = "";
            }
            if (email.Text == "" || email.Text == "                                                  ") {
                label4.Text = "";
            }
            if (birthDate.Text == "0001-01-01") {
                label5.Text = "";
                birthDate.Text = "";

            }
            if (street.Text == "" || street.Text == "                                                  ") {
                label7.Text = "";
            }
            if (city.Text == "" || city.Text == "                                                  ") {
                label9.Text = "";
            }
            if (postalCode.Text == "" || postalCode.Text == "                                                  ") {
                label8.Text = "";
            }
            if ((postalCode.Text == "" && street.Text == "" && city.Text == "") || (postalCode.Text == "                                                  " && street.Text == "                                                  " && city.Text == "                                                  ")) {
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                label6.Text = "";
            }
        }


    }
}
