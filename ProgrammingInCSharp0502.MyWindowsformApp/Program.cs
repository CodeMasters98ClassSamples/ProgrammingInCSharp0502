using ProgrammingInCSharp0502.MyWindowsformApp.Models;

namespace ProgrammingInCSharp0502.MyWindowsformApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int x = 0;
            //object , instance , شی , نمونه
            Student student = new Student();
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}