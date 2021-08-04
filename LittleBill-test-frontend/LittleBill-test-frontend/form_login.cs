using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LittleBill_test_frontend.Helpers;
using LittleBill_test_frontend_library;

namespace LittleBill_test_frontend
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            if (StringHelper.isNotNullOrEmpty(tbox_mail.Text) && StringHelper.isNotNullOrEmpty(tbox_password.Text))
            {
                if (await Library.Login(tbox_mail.Text, tbox_password.Text))
                    new form_LittleBill_Test(this).Show();
            }
        }

        private void lbl_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new form_register(this).Show();
        }

        private void tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btn_login.PerformClick();
        }
    }
}
