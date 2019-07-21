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
            usersController.AddUser(new User("fkatz", "fedefede")
            {
                Email = "fkatzaroff@gmail.com",
                Name = "Federico",
                Surname = "Katzaroff"
            });
            usersController.AddUser(new User("pepe", "44411777")
            {
                Email = "pepe@elpepe.com",
                Name = "Pepe",
                Surname = "Rodriguez"
            });
            usersController.AddUser(new User("toto", "toto99")
            {
                Email = "toto@totito.net",
                Name = "Toto",
                Surname = "Gonzalez"
            });
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm(usersController);
            Application.Run(loginForm);
        }
    }
}
