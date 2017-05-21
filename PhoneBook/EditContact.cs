using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class EditContact : Form
    {
        public EditContact() {
            InitializeComponent();
        }

        private void editAvatar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            contactAvatar.ImageLocation = openFileDialog1.FileName;
            contactAvatar.BackgroundImage = null;
            this.contactAvatar.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if(ComC.IsFiltered == true) {
                ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).LastName = lastName.Text;
                ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).PhoneNumber = phoneNumber.Text;
                ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).Email = email.Text;
                ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).BirthDate = birthDate.Text;
                ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).Street = street.Text;
                ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).PostalCode = postalCode.Text;
                ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).City = city.Text;
                ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).Avatar = contactAvatar.ImageLocation;
                ComC.people.Where(x => x.FirstName.ToLower() == ComC.Condition.ToLower()).ElementAt(ComC.ContactIndex).FirstName = firstName.Text;

                contactAvatar.BackgroundImage = null;
                contactAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else {
                ComC.people.ElementAt(ComC.ContactIndex).FirstName = firstName.Text;
                ComC.people.ElementAt(ComC.ContactIndex).LastName = lastName.Text;
                ComC.people.ElementAt(ComC.ContactIndex).PhoneNumber = phoneNumber.Text;
                ComC.people.ElementAt(ComC.ContactIndex).Email = email.Text;
                ComC.people.ElementAt(ComC.ContactIndex).BirthDate = birthDate.Text;
                ComC.people.ElementAt(ComC.ContactIndex).Street = street.Text;
                ComC.people.ElementAt(ComC.ContactIndex).PostalCode = postalCode.Text;
                ComC.people.ElementAt(ComC.ContactIndex).City = city.Text;
                ComC.people.ElementAt(ComC.ContactIndex).Avatar = contactAvatar.ImageLocation;
                contactAvatar.BackgroundImage = null;
                contactAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            }
            
            
            if (firstName.Text == "") {
                firstNameLabel.Text = "First Name*:";
                firstNameLabel.ForeColor = System.Drawing.Color.Red;
                errorNameLabel.Visible = true;
            }else if(phoneNumber.Text != "+" && !Regex.Match(phoneNumber.Text, @"^(\+[0-9]{9})$").Success) {
                phoneNumberLabel.Text = "Phone number*:";
                phoneNumberLabel.ForeColor = System.Drawing.Color.Red;
                errorPhoneLabel.Visible = true;
            }else if(email.Text != "" && !Regex.Match(email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success) {
                
                emailLabel.Text = "E-mail*:";
                emailLabel.ForeColor = System.Drawing.Color.Red;
                errorEmailLabel.Visible = true;
            }else if (birthDate.Value.ToShortDateString() == "1753-01-01") {
                birthDateLabel.Text = "Birth date*:";
                birthDateLabel.ForeColor = System.Drawing.Color.Red;
                errorBirthDateLabel.Visible = true;
            }
            else {
                Close();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditContact_Load(object sender, EventArgs e) {

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
            
        }
    }
}
