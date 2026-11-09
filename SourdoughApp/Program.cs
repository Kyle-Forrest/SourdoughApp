using Microsoft.EntityFrameworkCore;

namespace SourdoughApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            using (SourdoughDbContext db = new SourdoughDbContext())
            {
                db.Database.Migrate();
            }


            Application.Run(new LoginScreen());
        }
    }
}