using System;
using System.Collections.Generic;
using System.Text;

namespace SourdoughApp
{
    internal static class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    internal static class UserData
    {

        public static List<User> users = new List<User>
        {
            new User { Username = "admin", Password = "Pass123" },
            new User { Username = "Angie", Password = "Joe" },
            new User { Username = "Joe", Password = "Angie" }
        };
    }
}   

