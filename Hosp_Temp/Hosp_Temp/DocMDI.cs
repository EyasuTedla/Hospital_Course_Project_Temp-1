using System;
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
    public partial class DocMDI : Form
    {
        string logged_in_as;
        Form loginForm;
        public DocMDI(string logged_in_as, Form loginForm)
        {
            InitializeComponent();
            this.logged_in_as = logged_in_as;
            this.loginForm = loginForm;
        }

        private void DocMDI_Load(object sender, EventArgs e)
        {
            signedInAsToolStripMenuItem.Text = "Signed in as " + logged_in_as;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            loginForm.Show();
        }
    }
}
