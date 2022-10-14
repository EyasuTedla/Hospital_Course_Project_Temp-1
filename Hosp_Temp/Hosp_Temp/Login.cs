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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lbl_Login_Click(object sender, EventArgs e)
        {
            lbl_Login.Top = 25;
            panel_LoginPanel.Visible = true;
            panel_LoginPanel.Top = 200;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lbl_Login.Top = 270;
            panel_LoginPanel.Visible = false;
        }
    }
}
