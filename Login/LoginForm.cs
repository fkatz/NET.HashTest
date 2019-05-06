using Controllers;
using System.Windows.Forms;

namespace Login
{
    public partial class LoginForm : Form
    {
        private UsersController usersController;
        public LoginForm(UsersController usersController)
        {
            this.usersController = usersController;
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, System.EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(usersController);
            registerForm.ShowDialog();
            if (registerForm.NewUser != null)
            {
                usersController.AddUser(registerForm.NewUser);
            }
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            if (!usersController.Login(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Invalid username or password", "Error");
            }
            else
            {
                ListForm listForm = new ListForm(usersController);
                Hide();
                listForm.ShowDialog();
                if (listForm.DialogResult != DialogResult.Abort)
                {
                    Show();
                }
                else Dispose();
            }
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }
    }
}
