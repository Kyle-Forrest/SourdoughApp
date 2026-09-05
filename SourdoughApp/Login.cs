using System;
using System.Collections.Generic;
using System.Text;

namespace SourdoughApp
{   
    internal class Login
    {
        private LoginScreen _loginForm;

        public Login(LoginScreen form)
        {
            _loginForm = form;
        }

        public string username { get; set; }
        public string password { get; set; }
        public bool isLoggedIn { get; set; }

        string[,] userCredentials = new string[,]
        {
            { "admin", "Pass123"},
            { "Joe", "Angie"},
            { "Angie", "Joe"}
        };



        public void CheckUserCredentials(string userName, string passWord)
        {
            bool result = false;
            username = userName;
            password = passWord;

            for (int i = 0; i < userCredentials.GetLength(0); i++)
            {
                //username = userCredentials[i, 0]
                //password = userCredentials[i, 1]

                if (userCredentials[i, 0] == userName && userCredentials[i, 1] == password)
                {
                    result = true;
                    MessageBox.Show("Succesfully logged in.");
                    break;
                }

                if (i == userCredentials.GetLength(0) - 1)
                    {
                    MessageBox.Show("Username or password invalid.");
                    }
            }

            isLoggedIn = result;
        }
    }
}
