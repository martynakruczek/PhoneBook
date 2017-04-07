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
    public partial class Form4 : Form
    {
        public Form4() {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label11_Click(object sender, EventArgs e) {

        }

        private void Form4_Load(object sender, EventArgs e) {

            label11.Text = ComC.people.ElementAt(ComC.ContactIndex).FirstName;
            label14.Text = ComC.people.ElementAt(ComC.ContactIndex).LastName;
            label13.Text = ComC.people.ElementAt(ComC.ContactIndex).PhoneNumber;
            label12.Text = ComC.people.ElementAt(ComC.ContactIndex).Email;
            label15.Text = ComC.people.ElementAt(ComC.ContactIndex).BirthDate.ToShortDateString();
            label16.Text = ComC.people.ElementAt(ComC.ContactIndex).Street;
            label17.Text = ComC.people.ElementAt(ComC.ContactIndex).PostalCode;
            label18.Text = ComC.people.ElementAt(ComC.ContactIndex).City;

        }
    }
}
