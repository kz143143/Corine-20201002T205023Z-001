﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corine
{
    public partial class AdminLandingPage : Form
    {
        public AdminLandingPage()
        {
            InitializeComponent();
        }

        private void UserRegistration_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new WelcomePage().Show();
            this.Hide();
        }
    }
}
