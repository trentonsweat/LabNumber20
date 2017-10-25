using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabNumber20.Models
{
    public class UserData
    {
        //members

        private string clientfirstname;
        private string clientlastname;
        private string clientemail;
        private string phonenumber;
        private string password;

        //properties

        public string ClientFirstName
        {
            set { clientfirstname = value; }
            get { return clientfirstname; }
        }
        public string ClientLastName
        {
            set { clientlastname = value; }
            get { return clientlastname; }
        }
        public string ClientEmail
        {
            set { clientemail = value; }
            get { return clientemail; }
        }

        public string PhoneNumber
        {
            set { phonenumber = value; }
            get { return phonenumber; }
        }

        public string Password
        {
            set { password = value; }
            get { return password; }
        }

        //default constructor
        public UserData()
        {
            ClientFirstName = "";
            ClientLastName = "";
            ClientEmail = "";
            PhoneNumber = "";
            Password = "";
        }
        //overloaded constructor
        public UserData(string fn, string ln, string e, string p, string pw)
        {
            ClientFirstName = fn;
            ClientLastName = ln;
            ClientEmail = e;
            PhoneNumber = p;
            Password = pw;
        }



    }
}