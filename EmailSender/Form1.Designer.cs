namespace EmailSender
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bodytxt = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.to = new System.Windows.Forms.Label();
            this.fromtxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.totxt = new System.Windows.Forms.TextBox();
            this.from = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.Label();
            this.subjecttxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.bodytxt);
            this.groupBox1.Location = new System.Drawing.Point(38, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message";
            // 
            // bodytxt
            // 
            this.bodytxt.Location = new System.Drawing.Point(6, 19);
            this.bodytxt.Name = "bodytxt";
            this.bodytxt.Size = new System.Drawing.Size(188, 275);
            this.bodytxt.TabIndex = 1;
            this.bodytxt.Text = "";
            this.bodytxt.TextChanged += new System.EventHandler(this.bodytxt_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.to);
            this.groupBox2.Controls.Add(this.fromtxt);
            this.groupBox2.Controls.Add(this.passwordtxt);
            this.groupBox2.Controls.Add(this.totxt);
            this.groupBox2.Controls.Add(this.from);
            this.groupBox2.Controls.Add(this.password);
            this.groupBox2.Controls.Add(this.subject);
            this.groupBox2.Controls.Add(this.subjecttxt);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(277, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 300);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 3);
            this.label5.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(66, 209);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Gmail";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(66, 232);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Yahoo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(19, 126);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(16, 13);
            this.to.TabIndex = 7;
            this.to.Text = "to";
            // 
            // fromtxt
            // 
            this.fromtxt.Location = new System.Drawing.Point(88, 40);
            this.fromtxt.Name = "fromtxt";
            this.fromtxt.Size = new System.Drawing.Size(100, 20);
            this.fromtxt.TabIndex = 1;
            this.fromtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(88, 70);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(100, 20);
            this.passwordtxt.TabIndex = 2;
            // 
            // totxt
            // 
            this.totxt.Location = new System.Drawing.Point(88, 123);
            this.totxt.Name = "totxt";
            this.totxt.Size = new System.Drawing.Size(100, 20);
            this.totxt.TabIndex = 3;
            this.totxt.TextChanged += new System.EventHandler(this.totxt_TextChanged);
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Location = new System.Drawing.Point(19, 43);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(27, 13);
            this.from.TabIndex = 5;
            this.from.Text = "from";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(19, 73);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(52, 13);
            this.password.TabIndex = 6;
            this.password.Text = "password";
            // 
            // subject
            // 
            this.subject.AutoSize = true;
            this.subject.Location = new System.Drawing.Point(19, 156);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(41, 13);
            this.subject.TabIndex = 8;
            this.subject.Text = "subject";
            // 
            // subjecttxt
            // 
            this.subjecttxt.Location = new System.Drawing.Point(88, 153);
            this.subjecttxt.Name = "subjecttxt";
            this.subjecttxt.Size = new System.Drawing.Size(100, 20);
            this.subjecttxt.TabIndex = 4;
            this.subjecttxt.TextChanged += new System.EventHandler(this.subjecttxt_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(24, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 71);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MailServer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(558, 405);
            this.MinimumSize = new System.Drawing.Size(558, 405);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox bodytxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.TextBox fromtxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox totxt;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label subject;
        private System.Windows.Forms.TextBox subjecttxt;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

