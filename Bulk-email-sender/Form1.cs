using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulk_email_sender
{
    public partial class Form1 : Form
    {
        private List<string> parameters;
        private Dictionary<string, List<string>> allParams;
        private List<List<string>> attachedFiles;

        private string email;
        private string password;
        private string displayName;

        public (string, string, string) getEmailAndPassword()
        {
            return (email, password, displayName);
        }


        private string formTextFromParams(string text, int id)
        {
            string finalText = "";
            int start = 0;
            int end = 0;
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '{')
                {
                    start = i;
                    count++;
                }
                if (text[i] == '}')
                {
                    end = i;
                    count++;
                }
                if (count == 2)
                {
                    try
                    {
                        string parametre = text.Substring(start + 1, end - start - 1);
                        finalText += text.Substring(0, start);
                        finalText += allParams[parametre][id];
                        text = text.Substring(end + 1);
                        i = 0;
                        count = 0;
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }

            finalText += text;

            return finalText;
        }

        public string getHtmlBody(int id)
        {
            return formTextFromParams(htmlEditControl1.DocumentHTML, id);
        }

        public string getSubject(int id)
        {
            return formTextFromParams(textBox1.Text, id);
        }

        public string GetEmailAddress(int id)
        {
            return allParams[emailsParamName][id];
        }

        public int getEntriesCount()
        {
            if (allParams.Count == 0)
            {
                return 0;
            }

            return allParams[parameters[0]].Count;
        }

        public int getAttachedFileCount()
        {
            if (attachedFiles.Count == 0)
            {
                return 0;
            }

            return attachedFiles.Count;
        }

        public List<string> getAttachedFiles(int id)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < attachedFiles.Count; i++)
            {
                for (int j = 0; j < attachedFiles[i].Count; j++)
                {
                    if (j == id)
                    {
                        result.Add(attachedFiles[i][j]);
                    }
                }
            }

            return result;
        }

        private string emailsParamName = "Email Addresses";

        public Form1()
        {
            InitializeComponent();
            label2.Hide();
            label3.Hide();
            label3.Text = "";
            label3.MaximumSize = new Size(400, 0);

            // Make combobox text color black
            parametreComboBox.ForeColor = Color.Black;

            richTextBox2.Enabled = false;

            parameters = new List<string> { };
            allParams = new Dictionary<string, List<string>> { };
            attachedFiles = new List<List<string>> { };

            parametreComboBox.Items.Add(emailsParamName);
        }

        private void addParam_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < parametreComboBox.Items.Count; i++)
            {
                string value = parametreComboBox.GetItemText(parametreComboBox.Items[i]);
                if (value.Contains(parametreComboBox.Text))
                {
                    count++;
                    break;
                }
            }

            if (count == 0)
            {
                // Add value to combobox
                parametreComboBox.Items.Add(parametreComboBox.Text);
            }
        }

        private void attachFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;


            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialog.FileNames.Length > 0)
                {
                    label2.Show();
                    label3.Show();
                }

                attachedFiles.Add(new List<string> { });
                int idx = 1;
                label3.Text += attachedFiles.Count.ToString() + ". ";
                foreach (string fileName in openFileDialog.FileNames)
                {
                    // show only filename without path
                    label3.Text += idx++ + " " + fileName.Substring(fileName.LastIndexOf("\\") + 1) + "  ";
                    attachedFiles[attachedFiles.Count - 1].Add(fileName);
                }

                label3.Text += "\n\n";
            }
        }

        private void parseParams(string text)
        {
            if (text == null)
            {
                return;
            }
            int start = 0;
            int end = 0;
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '{')
                {
                    start = i;
                    count++;
                }
                if (text[i] == '}')
                {
                    end = i;
                    count++;
                }
                if (count == 2)
                {
                    try
                    {
                        string parametre = text.Substring(start + 1, end - start - 1);
                        if (parametre == emailsParamName)
                        {
                            MessageBox.Show("You can't use " + emailsParamName + " as parametre name");
                            continue;
                        }
                        int count2 = 0;
                        for (int j = 0; j < parametreComboBox.Items.Count; j++)
                        {
                            string value = parametreComboBox.GetItemText(parametreComboBox.Items[j]);
                            if (value.Contains(parametre))
                            {
                                count2++;
                                break;
                            }
                        }

                        if (count2 == 0)
                        {
                            // Add value to combobox
                            parametreComboBox.Items.Add(parametre);
                            parameters.Add(parametre);
                        }

                        count = 0;
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }

        private void htmlEditor_TextChanged(object sender, EventArgs e)
        {
            // parse text and extract parametres insode {}
            parseParams(htmlEditControl1.DocumentPlainText);
            
        }

        private void clearParams_Click(object sender, EventArgs e)
        {
            parametreComboBox.Items.Clear();
            parameters.Clear();
            allParams.Clear();
        }

        private void parametreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox2.Enabled = true;
            if (allParams.ContainsKey(parametreComboBox.Text))
            {
                richTextBox2.Text = "";

                for (int i = 0; i < allParams[parametreComboBox.Text].Count; i++)
                {
                    richTextBox2.Text += allParams[parametreComboBox.Text][i] + "\n";
                }
            }
            else
            {
                richTextBox2.Text = "";
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            // Add parametre to dictionary
        }

        private void leaveRichTextBox2(object sender, EventArgs e)
        {
            //delete key value from dictionery first
            allParams.Remove(parametreComboBox.Text);

            // parse line by linne 
            string text = richTextBox2.Text;
            if (text == "")
            {
                return;
            }

            string[] lines = text.Split(new string[] { "\n" }, StringSplitOptions.None);
            List<string> values = new List<string> { };
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] != "")
                {
                    values.Add(lines[i]);
                }
            }

            allParams.Add(parametreComboBox.Text, values);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            bool disable = true;
            string top = parametreComboBox.Text;
            for (int j = 0; j < parametreComboBox.Items.Count; j++)
            {
                string value = parametreComboBox.GetItemText(parametreComboBox.Items[j]);
                if (value == top)
                {
                    disable = false;
                    break;
                }
            }

            if (disable)
            {
                richTextBox2.Enabled = false;
                richTextBox2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (parameters.Count == 0)
            {
                MessageBox.Show("Please add at least one parametre");
                return;
            }

            if (!allParams.TryGetValue(parameters[0], out List<string> initialValue))
            {
                MessageBox.Show("Please add values for each parametre");
                return;
            }


            // check if each parametre has same number of values
            bool sameSize = true;
            for (int i = 0; i < parameters.Count; i++)
            {
                if (!allParams.TryGetValue(parameters[i], out List<string> value))
                {
                    MessageBox.Show("Please add values for each parametre");
                    return;
                }

                if (initialValue.Count != value.Count)
                {
                    sameSize = false;
                }
            }

            if (!sameSize)
            {
                MessageBox.Show("Each parametre must have same number of values");
                return;
            }

            bool filesSameSize = true;
            for (int i = 0; i < attachedFiles.Count; i++)
            {
                if (attachedFiles[i].Count != initialValue.Count)
                {
                    filesSameSize = false;
                }
            }

            if (!filesSameSize)
            {
                MessageBox.Show("Each attachment must have same number of values");
                return;
            }



            // launch other form
            Form2 form2 = new Form2();
            form2.Show();

            // disable this form
            this.Enabled = false;

            // make form become enable  when form2 is closed
            form2.FormClosed += new FormClosedEventHandler((object sender1, FormClosedEventArgs e1) => { this.Enabled = true; });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // clear attached files
            attachedFiles.Clear();
            label3.Text = "";
        }

        private void leaveSubjectTextBox(object sender, EventArgs e)
        {
            parseParams(textBox1.Text);
        }

        private bool updateEmailAndPassword()
        {
            string applicationPath = Path.GetFullPath(System.AppDomain.CurrentDomain.BaseDirectory);
            string saveFilePath = Path.Combine(applicationPath, "loginCred.txt");
            if (File.Exists(saveFilePath))
            {
                var lines = File.ReadLines(saveFilePath);
                try
                {
                    email = lines.ElementAt(0);
                    password = lines.ElementAt(1);
                    displayName = lines.ElementAt(2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("smth not good");
                }

                label5.Text = email;
                label6.Text = displayName;
            }
            else
            {
                return true;
            }

            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var result = updateEmailAndPassword();
            if (result)
            {
                // launch other form
                Form3 form3 = new Form3();
                form3.Show();
                form3.TopMost = true;

                // disable this form
                this.Enabled = false;

                // make form become enable  when form2 is closed
                form3.FormClosed += new FormClosedEventHandler((object sender1, FormClosedEventArgs e1) => { 
                    this.Enabled = true; 
                    updateEmailAndPassword(); 
                });
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // launch other form
            Form3 form3 = new Form3();
            form3.Show();
            form3.TopMost = true;

            // disable this form
            this.Enabled = false;

            // make form become enable  when form2 is closed
            form3.FormClosed += new FormClosedEventHandler((object sender1, FormClosedEventArgs e1) => { 
                this.Enabled = true;
                updateEmailAndPassword();
            });
        }
    }
}
