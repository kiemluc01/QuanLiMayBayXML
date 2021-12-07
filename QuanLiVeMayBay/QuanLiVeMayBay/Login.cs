using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuanLiVeMayBay
{
    public partial class Login : Form
    {
        private String username = "", password="";
        public string Username
        {
            get
            { return username; }
            set
            { username = value; }
        }
        public string Password
        {
            get
            { return password; }
            set
            { password = value; }
        }
        XDocument doc;
       // XDocument doc = XDocument.Load("Accounts.xml");
        public String path = "account.xml";
        public Login()
        {
            InitializeComponent();
        }
        void load(String path)
        {
            try
            {
                doc = XDocument.Load(path);
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        void tam()
        {
            MessageBox.Show("Đăng nhặp thành công");
            //if (e.Element("quyen").Value == "0")
            //{
             //   Form1 f1 = new Form1();
              //  f1.Show();
            //}
            //else
            //{
              //  Form1 f1 = new Form1();
               // f1.Show();
          //}
        }
        void login_1(String username1, String pass)
        {
            load(path);
            int condition = 0;
            foreach(var e in doc.Descendants("account"))
            {
                if(e.Element("username").Value == username1)
                {
                    if (e.Element("pass").Value == pass)
                    {
                        condition = 1;
                        MessageBox.Show("Đăng nhặp thành công");
                        if (e.Element("quyen").Value == "0")
                        {
                            Form1 f1 = new Form1();
                            f1.Show();
                            this.Hide();
                        }
                        else
                        {
                            Form1 f1 = new Form1();
                            f1.Show();
                            this.Hide();
                        }
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu");
                        break;
                    }
                }
            }
            if(condition == 0)
            {
                MessageBox.Show("Sai tài khoản");
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            String username1 = txtUser.Text;
            String pass = txtPass.Text;
            login_1(username1,pass);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUser.Text = username;
            txtPass.Text = password;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new register().Show();
            this.Hide();
        }
    }  
}
