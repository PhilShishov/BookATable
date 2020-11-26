
namespace BookATable.GUI
{
    using System;
    using System.Windows.Forms;

    using BookATable.Common;
    using Services;

    public partial class FormLogin : Form
    {
        private const string LoginFormMessageDisplay = "Login Form";

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
                    MessageBox.Show(
                        ErrorMessages.InvalidLogin,
                        GlobalConstants.LoginFailureCaption,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                throw new ApplicationException(string.Format(ErrorMessages.ErrorMessageTemplate, LoginFormMessageDisplay), ex);
            }

        }
    }
}
