using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulk_email_sender
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please enter email and password");
                return;
            }

            var email = textBox1.Text;
            var password = textBox2.Text;
            var displayName = textBox3.Text;

            // safe to file
            string applicationPath = Path.GetFullPath(System.AppDomain.CurrentDomain.BaseDirectory);
            string saveFilePath = Path.Combine(applicationPath, "loginCred.txt");
            StreamWriter w = new StreamWriter(saveFilePath, false);
            w.WriteLine(email);
            w.WriteLine(password);
            w.WriteLine(displayName);
            w.Close();

            this.Close();
        }
    }
}
