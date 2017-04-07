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
    public partial class Form1 : Form
    {
        Form2 AddForm;
        Form4 ContactDetails;
        Form3 Birthday;
        Search Search;
        public Form1() {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm = new Form2();
            AddForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0) {
                ComC.ContactIndex = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(ComC.ContactIndex);
                ComC.people.RemoveAt(ComC.ContactIndex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex >= 0) {
                ComC.ContactIndex = listBox1.SelectedIndex;
                ContactDetails = new Form4();
                ContactDetails.ShowDialog();
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search = new Search();
            Search.ShowDialog();

            if (ComC.Condition != "") {
                listBox1.Items.Clear();

                foreach (var item in ComC.people.Where(x => x.FirstName == ComC.Condition)) {
                    listBox1.Items.Add(item.FirstName);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var item in ComC.people) {
                listBox1.Items.Add(item.FirstName +" "+ item.LastName);
            }
            foreach (var item in ComC.people) {
                if (item.BirthDate.Date.Month == DateTime.Today.Month && item.BirthDate.Date.Day == DateTime.Today.Day) {
                    Birthday = new Form3(item);
                    Birthday.ShowDialog();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            pictureBox1.BackgroundImage = null;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) {

            listBox1.Items.Clear();

            foreach (var item in ComC.people) {
                listBox1.Items.Add(item.FirstName);
            }

            foreach (var item in ComC.people) {
                if(item.BirthDate.Date.Month == DateTime.Today.Month && item.BirthDate.Date.Day == DateTime.Today.Day) {
                    Birthday = new Form3(item);
                    Birthday.ShowDialog();
                }
            }
        }
    }
}
