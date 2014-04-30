using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupAssignment
{
    public partial class frm_changePassword : Form
    {
        public frm_changePassword()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Boolean error = false;
            ArrayList errorList = new ArrayList();
            errorList.Clear();
            lbl_errors.Text = "";

            txt_confirmpwd.BackColor = Color.White;
            txt_curpwd.BackColor = Color.White;
            txt_newpwd.BackColor = Color.White;

            if (txt_curpwd.Text == "")
            {
                error = true;
                txt_curpwd.BackColor = Color.LightPink;
                errorList.Add("Enter current password");
                txt_curpwd.Focus();
            }

            if (txt_newpwd.Text == "")
            {
                error = true;
                txt_newpwd.BackColor = Color.LightPink;
                errorList.Add("Enter new password");
                if (!error) txt_newpwd.Focus();
            }

            if (txt_confirmpwd.Text == "")
            {
                error = true;
                txt_confirmpwd.BackColor = Color.LightPink;
                errorList.Add("Confirm the password");
                if (!error) txt_confirmpwd.Focus();
            }

            if (txt_confirmpwd.Text != txt_newpwd.Text)
            {
                error = true;
                txt_confirmpwd.BackColor = Color.LightPink;
                txt_newpwd.BackColor = Color.LightPink;
                errorList.Add("New passwords does not match");
            }
            string hash = DataBase.getHashCodeFromDB(User.curUsername);
            if ((!error) && (txt_curpwd.Text.GetHashCode().ToString() != DataBase.getHashCodeFromDB(User.curUsername)))
            {
                error = true;
                txt_curpwd.BackColor = Color.LightPink;
                errorList.Add("Current password is wrong");
                if (!error) txt_curpwd.Focus();
            }


            if (error)
            {
                foreach (String err in errorList)
                    lbl_errors.Text += err + "\n";
            }
            else
            {
                if (DataBase.updatePassword(User.curUsername, txt_newpwd.Text))
                    lbl_errors.Text = "Password updated";
            }
        }
    }
}
