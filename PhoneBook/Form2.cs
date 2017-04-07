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
            Person p = new Person();
            p.FirstName = textBox1.Text;
            p.LastName = textBox2.Text;
            p.PhoneNumber = textBox3.Text;
            p.Email = textBox4.Text;
            p.BirthDate = dateTimePicker1.Value;
            p.Street = textBox6.Text;
            p.PostalCode = textBox7.Text;
            p.City = textBox8.Text;



            ComC.people.Add(p);
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e) {
            
        }



        private void Form2_Load(object sender, EventArgs e) {

        }
    }
}
