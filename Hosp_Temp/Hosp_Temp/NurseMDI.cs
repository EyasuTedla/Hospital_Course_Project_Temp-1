﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hosp_Temp
{
    public partial class NurseMDI : Form
    {
        private string logged_in_as;
        Form loginForm;

        public NurseMDI(string logged_in_as, Form loginForm)
        {
            InitializeComponent();
            this.logged_in_as = logged_in_as;
            this.loginForm = loginForm;
        }

        private void NurseMDI_Load(object sender, EventArgs e)
        {
            signedInAsToolStripMenuItem.Text = "Signed in as " + logged_in_as;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            loginForm.Show();
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
