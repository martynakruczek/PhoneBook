﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3() {
            InitializeComponent();
        }
        public Form3(Person p) {
            InitializeComponent();
            greetings.Text = "It's " + p.FirstName + " " + p.LastName + " birthday today!";
        }
        private void pictureBox1_Click(object sender, EventArgs e) {

        }
    }
}
