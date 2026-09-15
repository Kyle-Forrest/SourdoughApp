using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace SourdoughApp.LoginRegister
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



        public void CheckUserCredentials(string userName, string passWord)
        {
            bool result = false;
            username = userName;
            password = passWord;

            for (int i = 0; i < UserData.users.Count(); i++)
            {
                //username = userCredentials[i, 0]
                //password = userCredentials[i, 1]

                if (UserData.users[i].Username == userName && UserData.users[i].Password == password)
                {
                    result = true;
                    MessageBox.Show("Succesfully logged in.");
                    break;
                }

                if (i == UserData.users.Count() - 1)
                    {
                    MessageBox.Show("Username or password invalid.");
                    }
            }

            isLoggedIn = result;
        }
    }
}
