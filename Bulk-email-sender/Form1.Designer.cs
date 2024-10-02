namespace Bulk_email_sender
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.addParam = new System.Windows.Forms.Button();
            this.attachFiles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.parametreComboBox = new System.Windows.Forms.ComboBox();
            this.clearParams = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.htmlEditControl1 = new Zoople.HTMLEditControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(814, 78);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(257, 349);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            this.richTextBox2.Leave += new System.EventHandler(this.leaveRichTextBox2);
            // 
            // addParam
            // 
            this.addParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addParam.Location = new System.Drawing.Point(961, 46);
            this.addParam.Margin = new System.Windows.Forms.Padding(2);
            this.addParam.Name = "addParam";
            this.addParam.Size = new System.Drawing.Size(50, 29);
            this.addParam.TabIndex = 4;
            this.addParam.Text = "Add ";
            this.addParam.UseVisualStyleBackColor = true;
            this.addParam.Click += new System.EventHandler(this.addParam_Click);
            // 
            // attachFiles
            // 
            this.attachFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachFiles.Location = new System.Drawing.Point(670, 414);
            this.attachFiles.Margin = new System.Windows.Forms.Padding(2);
            this.attachFiles.Name = "attachFiles";
            this.attachFiles.Size = new System.Drawing.Size(130, 30);
            this.attachFiles.TabIndex = 5;
            this.attachFiles.Text = "Attach FIles";
            this.attachFiles.UseVisualStyleBackColor = true;
            this.attachFiles.Click += new System.EventHandler(this.attachFiles_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Attcahed files";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Files";
            // 
            // parametreComboBox
            // 
            this.parametreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parametreComboBox.FormattingEnabled = true;
            this.parametreComboBox.Location = new System.Drawing.Point(814, 45);
            this.parametreComboBox.Name = "parametreComboBox";
            this.parametreComboBox.Size = new System.Drawing.Size(142, 28);
            this.parametreComboBox.TabIndex = 8;
            this.parametreComboBox.SelectedIndexChanged += new System.EventHandler(this.parametreComboBox_SelectedIndexChanged);
            // 
            // clearParams
            // 
            this.clearParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearParams.Location = new System.Drawing.Point(1015, 45);
            this.clearParams.Margin = new System.Windows.Forms.Padding(2);
            this.clearParams.Name = "clearParams";
            this.clearParams.Size = new System.Drawing.Size(55, 29);
            this.clearParams.TabIndex = 9;
            this.clearParams.Text = "Clear";
            this.clearParams.UseVisualStyleBackColor = true;
            this.clearParams.Click += new System.EventHandler(this.clearParams_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(992, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Finalize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(11, 554);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // htmlEditControl1
            // 
            this.htmlEditControl1.AcceptsReturn = true;
            this.htmlEditControl1.BaseURL = null;
            this.htmlEditControl1.CleanMSWordHTMLOnPaste = true;
            this.htmlEditControl1.CodeEditor.Enabled = true;
            this.htmlEditControl1.CodeEditor.Font = new System.Drawing.Font("Courier New", 10F);
            this.htmlEditControl1.CodeEditor.Locked = false;
            this.htmlEditControl1.CodeEditor.TabWidth = 720;
            this.htmlEditControl1.CodeEditor.WordWrap = false;
            this.htmlEditControl1.CSSText = null;
            this.htmlEditControl1.DocumentHTML = null;
            this.htmlEditControl1.EnableInlineSpelling = false;
            this.htmlEditControl1.FontSizesList = null;
            this.htmlEditControl1.FontsList = null;
            this.htmlEditControl1.HiddenButtons = null;
            this.htmlEditControl1.ImageStorageLocation = null;
            this.htmlEditControl1.InCodeView = false;
            this.htmlEditControl1.IndentAmount = 2;
            this.htmlEditControl1.IndentsUseBlockuote = false;
            this.htmlEditControl1.LanguageFile = null;
            this.htmlEditControl1.LicenceActivationKey = null;
            this.htmlEditControl1.LicenceKey = null;
            this.htmlEditControl1.LicenceKeyInlineSpelling = null;
            this.htmlEditControl1.Location = new System.Drawing.Point(0, 0);
            this.htmlEditControl1.Name = "htmlEditControl1";
            this.htmlEditControl1.Size = new System.Drawing.Size(800, 419);
            this.htmlEditControl1.TabIndex = 12;
            this.htmlEditControl1.ToolstripImageScalingSize = new System.Drawing.Size(16, 16);
            this.htmlEditControl1.UseParagraphAsDefault = true;
            this.htmlEditControl1.HTMLChanged += new Zoople.HTMLEditControl.HTMLChangedEventHandler(this.htmlEditor_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(871, 19);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 23);
            this.textBox1.TabIndex = 13;
            this.textBox1.Leave += new System.EventHandler(this.leaveSubjectTextBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(811, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Subject:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(811, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sender email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(912, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(814, 480);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 25);
            this.button3.TabIndex = 17;
            this.button3.Text = "Relogin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(912, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Email:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 594);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.attachFiles);
            this.Controls.Add(this.htmlEditControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clearParams);
            this.Controls.Add(this.parametreComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addParam);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button addParam;
        private System.Windows.Forms.Button attachFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox parametreComboBox;
        private System.Windows.Forms.Button clearParams;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Zoople.HTMLEditControl htmlEditControl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
    }
}

