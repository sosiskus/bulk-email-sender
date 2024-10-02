using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulk_email_sender
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        private int id = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void render()
        {
            htmlEditControl1.DocumentHTML = form1.getHtmlBody(id);
            label2.Text = (id+1).ToString() + "/" + form1.getEntriesCount().ToString();

            if (form1.getAttachedFileCount() <= 0)
            {
                label3.Text = "No attachments";
            }
            else
            {
                label4.Text = "";
                List<string> attachedFiles = form1.getAttachedFiles(id);
                foreach (string file in attachedFiles)
                {
                    // show just file name after /

                    label4.Text += file.Substring(file.LastIndexOf("\\") + 1) + " ";
                }
            }

            label6.Text = form1.GetEmailAddress(id);
            label7.Text = form1.getSubject(id);

            id++;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["Form1"];
            form1 = (Form1)f;

            render();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id >= form1.getEntriesCount())
            {
                MessageBox.Show("No more emails to show.");
                this.Close();
                return;
            }

            render();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string fromEmail = "whitedragon5634@gmail.com";
            //string fromName = "Nikita Klepikovs";
            //string password = "gbxt hayb zkvr pgwl";
            (string fromEmail, string password, string fromName) = form1.getEmailAndPassword();

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromEmail, password),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                EnableSsl = true,
            };

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(fromEmail, fromName);
            mail.To.Add(new MailAddress(form1.GetEmailAddress(id-1)));
            mail.Subject = form1.getSubject(id - 1);
            mail.Body = htmlEditControl1.DocumentHTML;
            mail.IsBodyHtml = true;

            if (form1.getAttachedFileCount() > 0)
            {
                List<string> attachedFiles = form1.getAttachedFiles(id - 1);
                foreach (string file in attachedFiles)
                {
                    mail.Attachments.Add(new Attachment(file));
                }
            }
            try
            {
                smtpClient.Send(mail);
                MessageBox.Show("Email sent successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
  
        }
    }
}
