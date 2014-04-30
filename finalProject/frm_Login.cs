using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Collections;

namespace groupAssignment
{
    public partial class frmLoginForm : Form
    {
        public frmLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;

            txtName.BackColor = Color.White;
            txtPassword.BackColor = Color.White;
            lbl_errors.Text = "";

            bool error = false;
            ArrayList errors = new ArrayList();
            if (txtName.Text == "")
            {
                error = true;
                errors.Add("Enter username!");
                txtName.BackColor = Color.LightPink;
                txtName.Focus();
            }

            if (txtPassword.Text == "")
            {
                if (!error) txtPassword.Focus();
                error = true;
                errors.Add("Enter password!");
                txtPassword.BackColor = Color.LightPink;
            }

            if (!error && txtPassword.Text.GetHashCode().ToString() != DataBase.getHashCodeFromDB(txtName.Text))
            {
                error = true;
                errors.Add("Wrong username/password!");
                txtName.Focus();
            }

            foreach (String str in errors)
            {
                lbl_errors.Text += str + "\n";
            }


            if (error) return;
            else
            {
                User user = DataBase.getUserByLogin(txtName.Text);
                if (user != null)
                {
                    User.curName = user.Name;
                    User.curUsername = user.Username;
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Registration frm_registration = new frm_Registration();
            frm_registration.ShowDialog();
        }

        private void llbl_forgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_restorePassword frm_restorePassword = new frm_restorePassword();
            frm_restorePassword.ShowDialog();
        }
    }
}
