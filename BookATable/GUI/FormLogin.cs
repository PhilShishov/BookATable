
namespace BookATable.GUI
{
    using global::BookATable.Services;
    using System;
    using System.Windows.Forms;

    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                AuthenticationService.Authenticate(textBoxEmail.Text, textBoxPassword.Text);

                if (AuthenticationService.LoggedUser != null)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Wrong email or password",
                                    "Login failure",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Something wrong happened in the Login Form :", ex);
            }

        }
    }
}
