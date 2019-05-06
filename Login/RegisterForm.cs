using Controllers;
using Entities;
using System.Windows.Forms;

namespace Login
{
    public partial class RegisterForm : Form
    {
        public User NewUser { get; set; }
        private UsersController usersController;
        public RegisterForm(UsersController usersController)
        {
            this.usersController = usersController;
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            Hide();
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            NewUser = new User(txtUsername.Text, txtPassword.Text)
            {
                Email = txtEmail.Text,
                Name = txtName.Text,
                Surname = txtSurname.Text
            };
            UsersController.UserValidation userValidation = usersController.ValidateUser(NewUser);
            if (userValidation == UsersController.UserValidation.VALID)
            {
                Hide();
            }
            else
            {
                string errors = "";
                if ((userValidation & UsersController.UserValidation.INVALID_NAME) == UsersController.UserValidation.INVALID_NAME)
                {
                    errors += "Invalid Name or Surname.\n";
                }
                if ((userValidation & UsersController.UserValidation.INVALID_EMAIL) == UsersController.UserValidation.INVALID_EMAIL)
                {
                    errors += "Invalid Email.\n";
                }
                if ((userValidation & UsersController.UserValidation.USERNAME_TAKEN) == UsersController.UserValidation.USERNAME_TAKEN)
                {
                    errors += "Username already taken.\n";
                }
                if ((userValidation & UsersController.UserValidation.INVALID_USERNAME) == UsersController.UserValidation.INVALID_USERNAME)
                {
                    errors += "Invalid Username.\n";
                }
                MessageBox.Show(errors, "Error");
                NewUser = null;
            }
        }
    }
}
