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
using Oracle.DataAccess.Client;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;

namespace groupAssignment
{
    public partial class frm_Registration : Form
    {
        public frm_Registration()
        {
            InitializeComponent();
        }

        public Boolean isLoginOccupied(String login)
        {
            if (DataBase.getCountOfUsers(login) == "0") 
                return true;
            else 
                return false;
        }

        public Boolean isEmailOccupied(String email)
        {
            if (DataBase.getCountOfEmails(email) == "0") 
                return true;
            else 
                return false;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void sendEmail(String targetEmail, String targetName, String targetLogin, String password)
        {
            String body;

            body = "Dear " + targetName + ", \n\n";
            body += "Thank you for registration! \n";
            body += "\t Your login: " + targetLogin + "\n";
            body += "\t Your password: " + password + "\n\n";
            body += "----------------\n";
            body += "Sincerely, Software Development Team";


            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(
                  "noreply.application@gmail.com", "humber123");
                MailMessage msg = new MailMessage();
                msg.To.Add(targetEmail);
                msg.From = new MailAddress("noreply.application@gmail.com");
                msg.Subject = "REGISTRATION";
                msg.Body = body;
                client.SendAsync(msg, "message");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {

            lbl_errors.Text = "";
            txt_email.BackColor = Color.White;
            txt_login.BackColor = Color.White;
            txt_name.BackColor = Color.White;

            ArrayList ErrorList = new ArrayList();
            bool error = false; ;

            if (txt_name.Text == "")
            {
                txt_name.Focus();
                txt_name.BackColor = Color.LightPink;
                ErrorList.Add("Name field can not be empty!");
                error = true;
            }

            if (!IsValidEmail(txt_email.Text))
            {
                if (!error) txt_email.Focus();
                txt_email.BackColor = Color.LightPink;
                ErrorList.Add("Enter valid e-mail address!");
                error = true;
            }

            if (txt_login.Text == "")
            {
                txt_login.BackColor = Color.LightPink;
                ErrorList.Add("Login field can not be empty!");
                error = true;
                if (!error) txt_login.Focus();
            }

            if (txt_login.Text.Length >= 20)
            {
                error = true;
                ErrorList.Add("Username is too long!");
                txt_login.BackColor = Color.LightPink;
                txt_login.Focus();
            }

            if (txt_name.Text.Length >= 60)
            {
                error = true;
                ErrorList.Add("Name is too long!");
                txt_name.BackColor = Color.LightPink;
                txt_name.Focus();
            }

            if (txt_email.Text.Length >= 60)
            {
                error = true;
                ErrorList.Add("Email is too long!");
                txt_email.BackColor = Color.LightPink;
                txt_email.Focus();
            }

            if (DataBase.getCountOfUsers(txt_login.Text)!="0")
            {
                if (!error) txt_login.Focus();
                ErrorList.Add("Such login is allready exists!");
                error = true;
            }

            if (DataBase.getCountOfEmails(txt_email.Text)!="0")
            {
                if (!error) txt_email.Focus();
                ErrorList.Add("Such email is allready registered!");
                error = true;
            }

            if (!chkbx_license.Checked)
            {
                if (!error) chkbx_license.Focus();
                ErrorList.Add("You have to accept with a license agreement!");
                error = true;
            }

            foreach (string str in ErrorList)
            {
                lbl_errors.Text += str + "\n";
            }

            if (error) return;

            String password = RandomString(8);

            if (DataBase.addNewUser(txt_login.Text, password, txt_name.Text, txt_email.Text))
            {
                sendEmail(txt_email.Text, txt_name.Text, txt_login.Text, password);
                lbl_errors.Text = txt_name.Text + ", thank you for registration.\n";
                lbl_errors.Text += "You will receive an email with your password shortly.";
            }

            DataBase.addUserQuotes(txt_login.Text, "ADBE");
            DataBase.addUserQuotes(txt_login.Text, "MSFT");
            DataBase.addUserQuotes(txt_login.Text, "AAPL");
            DataBase.addUserQuotes(txt_login.Text, "GOOG");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
