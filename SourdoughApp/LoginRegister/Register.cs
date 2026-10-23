using System;
using System.Collections.Generic;
using System.Text;

namespace SourdoughApp.LoginRegister
{
    internal class Register
    {
        private RegisterScreen _registerScreen;

        public Register(RegisterScreen registerScreen)
        {
            _registerScreen = registerScreen;
        }

            public string userName { get; set; }
            public string passWord { get; set; }
            public string passCheck { get; set; }

            public bool RegisterAccount(string username, string passWord, string passCheck)
            {
                using (SourdoughDbContext db = new SourdoughDbContext())
                {
                    User newUser = new User
                    {
                        Username = username,
                        Password = passWord
                    };

                    bool registered = false;


                    if (passWord == passCheck && !(UserData.users.Any(user => user.Username == username)))
                    {
                        db.Users.Add(new User { Username = username, Password = passWord });
                        db.SaveChanges();
                        MessageBox.Show("Account registered successfully");
                        registered = true;
                    }
                

                return registered;
                }
            }
    }
}
