using Controllers;
using Entities;
using System;
using System.Windows.Forms;

namespace Login
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UsersController usersController = new UsersController();
            usersController.AddUser(new User("fkatz", "fede")
            {
                Email = "fkatzaroff@gmail.com",
                Name = "Federico",
                Surname = "Katzaroff"
            });
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm(usersController);
            Application.Run(loginForm);
        }
    }
}
