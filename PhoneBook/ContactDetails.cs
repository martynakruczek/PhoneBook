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

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ContactDetails_Load(object sender, EventArgs e) {


            if (ComC.IsFiltered == true) {

                firstName.Text = ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).FirstName;
                lastName.Text = ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).LastName;
                phoneNumber.Text = ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).PhoneNumber;
                email.Text = ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).Email;
                birthDate.Text = ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).BirthDate;
                street.Text = ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).Street;
                postalCode.Text = ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).PostalCode;
                city.Text = ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).City;
                contactAvatar.ImageLocation = ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).Avatar;
                contactAvatar.BackgroundImage = null;
                contactAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else {
                firstName.Text = ComC.people.ElementAt(ComC.ContactIndex).FirstName;
                lastName.Text = ComC.people.ElementAt(ComC.ContactIndex).LastName.Trim();
                phoneNumber.Text = ComC.people.ElementAt(ComC.ContactIndex).PhoneNumber.Trim();
                email.Text = ComC.people.ElementAt(ComC.ContactIndex).Email.Trim();
                birthDate.Text = ComC.people.ElementAt(ComC.ContactIndex).BirthDate.Trim();
                street.Text = ComC.people.ElementAt(ComC.ContactIndex).Street.Trim();
                postalCode.Text = ComC.people.ElementAt(ComC.ContactIndex).PostalCode.Trim();
                city.Text = ComC.people.ElementAt(ComC.ContactIndex).City.Trim();
                contactAvatar.ImageLocation = ComC.people.ElementAt(ComC.ContactIndex).Avatar;
                contactAvatar.BackgroundImage = null;
                contactAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            }

            if (lastName.Text == "") {
                lastNameLabel.Text = "";
            }
            if (phoneNumber.Text == "+") {
                phoneNumberLabel.Text = "";
                phoneNumber.Text = "";
            }
            if (email.Text == "") {
                emailLabel.Text = "";
            }
            if (birthDate.Text == "1 stycznia 1917") {
                birthDateLabel.Text = "";
                birthDate.Text = "";

            }
            if (street.Text == "") {
                streetLabel.Text = "";
            }
            if (city.Text == "") {
                cityLabel.Text = "";
            }
            if (postalCode.Text == "") {
                postalCodeLabel.Text = "";
            }
            if (postalCode.Text == "" && street.Text == "" && city.Text == "") {
                streetLabel.Text = "";
                postalCodeLabel.Text = "";
                cityLabel.Text = "";
                addressLabel.Text = "";
            }
        }
    }
}
