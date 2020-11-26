namespace BookATable.GUI
{
    using System;
    using System.Windows.Forms;

    using BookATable.Common;
    using Entities;

    public partial class FormAddEditUser : Form
    {
        private User user;
        private const int MIN_LENGTH = 8;
        private const string AddEditUserDisplay = "Add-Edit User";

        public FormAddEditUser(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FormAddEditUser_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = string.Format("{0} - Book a Table", user.Id > 0 ? "Edit user" : "Add user");

                textBoxName.Text = user.Name;
                textBoxPassword.Text = user.Password;
                textBoxPassword.PasswordChar = '*';
                textBoxEmail.Text = user.Email;
                textBoxPhone.Text = user.Phone;
                checkBoxIsAdmin.Checked = user.IsAdmin;
            }

            catch (Exception ex)
            {
                throw new ApplicationException(string.Format(ErrorMessages.ErrorMessageTemplate, AddEditUserDisplay), ex);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                user.Name = textBoxName.Text;
                user.Password = textBoxPassword.Text;
                user.Email = textBoxEmail.Text;
                user.Phone = textBoxPhone.Text;
                user.IsAdmin = checkBoxIsAdmin.Checked;

                if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxPassword.Text) ||
                    string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxPhone.Text))
                {
                    this.DialogResult = DialogResult.Abort;
                    MessageBox.Show(ErrorMessages.EmptyInputFields);
                }

                if (textBoxPassword.TextLength < MIN_LENGTH)
                {
                    this.DialogResult = DialogResult.Abort;
                    MessageBox.Show(ErrorMessages.InvalidPassword);
                }
            }
            catch (Exception ex)
            {

                throw new ApplicationException(string.Format(ErrorMessages.ErrorMessageTemplate, AddEditUserDisplay), ex);
            }
        }
    }
}
