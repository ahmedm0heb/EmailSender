using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace EmailSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage Mail = new MailMessage(fromtxt.Text,totxt.Text,subjecttxt.Text,bodytxt.Text);
            string SMTP = "smtp.gmail.com";
            if(radioButton1.Checked)
                SMTP = "smtp.gmail.com";
            else if(radioButton2.Checked)
                SMTP = "smtp.mail.yahoo.com";
            SmtpClient Client = new SmtpClient(SMTP, 465);
            Client.UseDefaultCredentials = false;
            Client.Credentials = new NetworkCredential(fromtxt.Text, passwordtxt.Text);
            Client.EnableSsl = true;
            try
            {
                Client.Send(Mail);
                MessageBox.Show("mail :- " + subject.Text + " Sent successfully","Message sent" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                bodytxt.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("cause of"+ ex.Message , " message can't sent" , MessageBoxButtons.OK, MessageBoxIcon.Error ,MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckData();
        }
        private void bodytxt_TextChanged(object sender, EventArgs e)
        {
            CheckData();

        }
        private void totxt_TextChanged(object sender, EventArgs e)
        {
            CheckData();
        }

        private void subjecttxt_TextChanged(object sender, EventArgs e)
        {
            CheckData();
        }
        private void CheckData()
        {
            if(bodytxt.Text=="" && fromtxt.Text=="" && totxt.Text=="" && subjecttxt.Text == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

       
    }
    
}
