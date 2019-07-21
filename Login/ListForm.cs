using System.Windows.Forms;
using Controllers;
using Entities;

namespace Login
{
    public partial class ListForm : Form
    {
        private UsersController usersController;
        public ListForm(UsersController usersController)
        {
            this.usersController = usersController;
            InitializeComponent();
            grdUsers.DataSource = usersController.ListUsers();
        }

        private void ListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(DialogResult != DialogResult.OK) DialogResult = DialogResult.Abort;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }
}
