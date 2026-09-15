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

            public void RegisterAccount(string username, string password, string passcheck)
            {
                
            }
    }
}
