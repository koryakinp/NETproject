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
using System.Net;
using System.Net.Mail;

namespace groupAssignment
{
    public partial class frm_restorePassword : Form
    {

        public frm_restorePassword()
        {
            InitializeComponent();
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

        public void sendEmail(String targetEmail, String targetName, String targetLogin, String password)
        {
            String body;

            body = "Dear " + targetName + ", \n\n";
            body += "Thank you for using our application! \n";
            body += "Below is your authentication information: \n\n";
            body += "\t Your login: " + targetLogin + "\n";
            body += "\t Your new password: " + password + "\n\n";
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
                msg.Subject = "NEW PASSWORD REQUEST";
                msg.Body = body;
                client.SendAsync(msg, "message");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_submit_Click(object sender, EventArgs e)
        {
            bool error = false;
            ArrayList errors = new ArrayList();
            txt_loginPass.BackColor = Color.White;
            lbl_errors.Text = "";

            if (txt_loginPass.Text == "")
            {
                txt_loginPass.Focus();
                errors.Add("The field can not be empty!");
                txt_loginPass.BackColor = Color.LightPink;
                error = true;
            }

            User user = DataBase.getUserByLogin(txt_loginPass.Text);

            if (!error && (user==null))
            {
                txt_loginPass.Focus();
                errors.Add("Can not find user " + txt_loginPass.Text);
                error = true;
            }

            foreach (String str in errors)
            {
                lbl_errors.Text += str + "\n";
            }

            if (error) return;
            else
            {
                string password = RandomString(8);
                if (DataBase.updatePassword(user.Username, password))
                {
                    sendEmail(user.Email, user.Name, user.Username, password);
                    lbl_errors.Text = "New password has been send to your email";
                }
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
