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
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_age.Text = "";
            txt_gender.Text = "";
            txt_ID.Text = "";
            txt_lname.Text = "";
            txt_name.Text = "";
            txt_null.Text = "";
        }
    }
}
