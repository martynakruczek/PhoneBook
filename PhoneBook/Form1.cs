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

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

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
    }
}
