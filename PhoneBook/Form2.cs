using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form2 : Form
    {
        public Form2() {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            pictureBox1.BackgroundImage = null;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e) {
            
        }

        class Person{
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public DateTime BirthDate { get; set; }
            public string Street { get; set; }
            public string PostalCode { get; set; }
            public string City { get; set; }

        }

        private void Form2_Load(object sender, EventArgs e) {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            if (!Directory.Exists(path + "\\Address Book"))
                Directory.CreateDirectory(path + "\\Address Book");
            if (!File.Exists(path + "\\Address Book\\settings.xml"))
                File.Create(path + "\\Address Book\\settings.xml");
        }
    }
}
