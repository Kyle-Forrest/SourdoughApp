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
            using (SourdoughDbContext db = new SourdoughDbContext())
            {
                bool result = false;
                username = userName;
                password = passWord;

                User? user = db.Users.FirstOrDefault(user => user.Username == userName && user.Password == passWord);

                    if (user != null)
                    {
                        result = true;
                        MessageBox.Show("Succesfully logged in.");
                       
                    }

                    else
                    {
                        MessageBox.Show("Username or password invalid.");
                    }
                

                isLoggedIn = result;
            }
        }
    }
}
