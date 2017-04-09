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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            contactAvatar.ImageLocation = openFileDialog1.FileName;
            contactAvatar.BackgroundImage = null;
            this.contactAvatar.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ComC.people.ElementAt(ComC.ContactIndex).FirstName = firstName.Text;
            ComC.people.ElementAt(ComC.ContactIndex).LastName = lastName.Text;
            ComC.people.ElementAt(ComC.ContactIndex).PhoneNumber = phoneNumber.Text;
            ComC.people.ElementAt(ComC.ContactIndex).Email = email.Text;
            ComC.people.ElementAt(ComC.ContactIndex).BirthDate = birthDate.Value;
            ComC.people.ElementAt(ComC.ContactIndex).Street = street.Text;
            ComC.people.ElementAt(ComC.ContactIndex).PostalCode = postalCode.Text;
            ComC.people.ElementAt(ComC.ContactIndex).City = city.Text;
            ComC.people.ElementAt(ComC.ContactIndex).Avatar = contactAvatar.ImageLocation;
            contactAvatar.BackgroundImage = null;
            contactAvatar.SizeMode = PictureBoxSizeMode.Zoom;


            if (birthDate.Value.ToShortDateString() == "2100-04-04") {
            }
            
            if (firstName.Text == "") {
                label2.Text = "First Name*:";
                label2.ForeColor = System.Drawing.Color.Red;
                errorLabel.Visible = true;
            }else if(phoneNumber.Text != "+" && !Regex.Match(phoneNumber.Text, @"^(\+[0-9]{9})$").Success) {
                label3.Text = "Phone number*:";
                label3.ForeColor = System.Drawing.Color.Red;
                errorLabel1.Visible = true;
            }else if(email.Text != "" && !Regex.Match(email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success) {
                
                label4.Text = "E-mail*:";
                label4.ForeColor = System.Drawing.Color.Red;
                errorLabel2.Visible = true;
            }else if (birthDate.Value.ToShortDateString() == "1753-01-01") {
                label5.Text = "Birth date*:";
                label5.ForeColor = System.Drawing.Color.Red;
                errorLabel3.Visible = true;
            }
            else {
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditContact_Load(object sender, EventArgs e) {

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
    }
}
