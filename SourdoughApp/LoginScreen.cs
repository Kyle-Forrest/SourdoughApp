using System;
using System.Collections.Generic;
using System.Text;

namespace SourdoughApp
{   
    internal class Login
    {
        private Form1 _mainForm;

        public Login(Form1 form)
        {
            _mainForm = form;
        }

        public string userName { get; set; }
        public string password { get; set; }

        string[,] userCredentials = new string[,]
        {
            { "admin", "Pass123"},
            { "Joe", "Angie"},
            { "Angie", "Joe"}
        };



        public bool Login(string userName, string password)
        {
            bool result = false;



            return result;
        }
    }
}
