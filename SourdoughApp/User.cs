using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SourdoughApp
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=users.db");
        }
        
    }
    
    public class User
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

