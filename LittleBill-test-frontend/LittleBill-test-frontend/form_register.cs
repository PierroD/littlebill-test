using LittleBill_test_frontend.Helpers;
using LittleBill_test_frontend_library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleBill_test_frontend
{
    public partial class form_register : Form
    {
        Form opener;
        public form_register(Form parentform)
        {
            InitializeComponent();
            opener = parentform;
        }

        private void form_register_Shown(object sender, EventArgs e)
        {
            changeOpenerVisibility();
        }

        private void changeOpenerVisibility()
        {
            this.opener.Visible = !this.opener.Visible;
        }

        private async void btn_register_Click(object sender, EventArgs e)
        {
            if (StringHelper.isNotNullOrEmpty(tbox_nom.Text) && StringHelper.isNotNullOrEmpty(tbox_email.Text) && StringHelper.isNotNullOrEmpty(tbox_password.Text))
                if (await Library.Register(tbox_nom.Text, tbox_email.Text, tbox_password.Text))
                    new form_LittleBill_Test(this).Show();

        }

        private void tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btn_register.PerformClick();
        }

    }
}
