using NorthwindFormsApp.Data;
using NorthwindFormsApp.Forms;

namespace NorthwindFormsApp
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

            // Create an instance of your DbContext
            using (var dbContext = new NorthwindDbContext()) // Replace with your DbContext class name
            {
                // Check if the database has not changed
                dbContext.Database.Initialize(true);
                Application.Run(new MainForm(dbContext));
            }
        }
    }
}