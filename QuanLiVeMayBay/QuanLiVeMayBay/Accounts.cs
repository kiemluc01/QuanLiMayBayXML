using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiVeMayBay
{
    class Accounts
    {
        private String username,pass,name,code,quyen;
        public string Username
        {
            get
            { return username; }
            set
            { username = value; }
        }
        public string Pass
        {
            get
            { return pass; }
            set
            { pass = value; }
        }
        public string Code
        {
            get
            { return code; }
            set
            { code = value; }
        }
        public string Name
        {
            get
            { return name; }
            set
            { name = value; }
        }
        public string Quyen
        {
            get
            { return quyen; }
            set
            { quyen = value; }
        }
    }
}
