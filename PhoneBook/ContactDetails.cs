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
        AddContact AddContact;
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

            if(lastName.Text == "") {
                label1.Text = "";
            }
            if (phoneNumber.Text == "+") {
                label3.Text = "";
                phoneNumber.Text = "";
            }
            if (email.Text == "") {
                label4.Text = "";
            }
            if (birthDate.Text == "") {
                label5.Text = "";
            }
            if (street.Text == "") {
                label7.Text = "";
            }
            if (city.Text == "") {
                label9.Text = "";
            }
            if (postalCode.Text == "") {
                label8.Text = "";
            }
            if(postalCode.Text == "" && street.Text == "" && city.Text == "") {
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                label6.Text = "";
            }
        }


    }
}
