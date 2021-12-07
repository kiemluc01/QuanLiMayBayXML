using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLiVeMayBay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
        void create()
        {
            XDocument XDoc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("User",
                    new XElement("account",
                        new XElement("code", "1"),
                        new XElement("username", "kiemluc01"),
                        new XElement("pass", "161101"),
                        new XElement("quyen", "0")),
                    new XElement("account",
                        new XElement("code", "2"),
                        new XElement("username", "kiemlucAD"),
                        new XElement("pass", "161101"),
                        new XElement("quyen", "1")),
                    new XElement("account",
                        new XElement("code", "3"),
                        new XElement("username", "vanthun1201"),
                        new XElement("pass", "120101"),
                        new XElement("quyen", "0")), 
                    new XElement("account",
                        new XElement("code", "4"),
                        new XElement("username", "vanthunAD"),
                        new XElement("pass", "120101"),
                        new XElement("quyen", "1"))
                    )
                );
            XDoc.Save("account.xml");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create();
        }
    }
}
