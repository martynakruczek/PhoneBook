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
    public partial class AddContact : Form
    {
        public AddContact() {
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
            Person p = new Person();
            p.FirstName = firstName.Text;
            p.LastName = lastName.Text;
            p.PhoneNumber = phoneNumber.Text;
            p.Email = email.Text;
            p.BirthDate = birthDate.Text;
            p.Street = street.Text;
            p.PostalCode = city.Text;
            p.City = postalCode.Text;
            p.Avatar = contactAvatar.ImageLocation;

            if (firstName.Text == "") {
                firstNameLabel.Text = "First Name*:";
                firstNameLabel.ForeColor = System.Drawing.Color.Red;
                errorNameLabel.Visible = true;
            }else if(phoneNumber.Text != "+" && !Regex.Match(phoneNumber.Text, @"^(\+[0-9]{9})$").Success) {
                phoneNumberLabel.Text = "Phone number*:";
                phoneNumberLabel.ForeColor = System.Drawing.Color.Red;
                errorPhoneNumberLabel.Visible = true;
            }else if(email.Text != "" && !Regex.Match(email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success) {
                
                emailLabel.Text = "E-mail*:";
                emailLabel.ForeColor = System.Drawing.Color.Red;
                errorEmailLabel.Visible = true;
            }
            else {
                if (ComC.people.Count > 0) {
                    p.Id = ComC.people.Max(x => x.Id) + 1;

                }
                else {
                    p.Id = 1;
                }
                ComC.people.Add(p);
                Close();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
