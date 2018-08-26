namespace BookATable.GUI
{
    using global::BookATable.Entities;
    using global::BookATable.Repositories;
    using System;
    using System.Windows.Forms;

    public partial class FormUsers : Form
    {
        private UserRepository repository;

        public FormUsers(UserRepository repository)
        {
            InitializeComponent();

            this.repository = repository;

            RefreshControls();
        }

        private void RefreshControls()
        {
            bindingSourceUsers.Clear();
            bindingSourceUsers.DataSource = repository.GetAll();
            dataGridViewUsers.DataSource = bindingSourceUsers;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                FormAddEditUser formAddUser = new FormAddEditUser(user);

                DialogResult dr = formAddUser.ShowDialog();
                if (dr == DialogResult.Abort)
                {
                    do
                    {
                        dr = formAddUser.ShowDialog();
                    } while (dr != DialogResult.OK && dr != DialogResult.Cancel);
                }
                if (dr == DialogResult.OK)
                {
                    repository.Insert(user);
                    RefreshControls();
                }

            }
            catch (Exception ex)
            {

                throw new ApplicationException("Something wrong happened in the Users Form :", ex);
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = (User)bindingSourceUsers.Current;
                if (user == null)
                {
                    return;
                }

                FormAddEditUser formEditUser = new FormAddEditUser(user);

                DialogResult dr = formEditUser.ShowDialog();
                if (dr == DialogResult.Abort)
                {
                    do
                    {
                        dr = formEditUser.ShowDialog();
                    } while (dr != DialogResult.OK && dr != DialogResult.Cancel);
                }
                if (dr == DialogResult.OK)
                {
                    repository.Update(user);
                    RefreshControls();
                }

            }
            catch (Exception ex)
            {

                throw new ApplicationException("Something wrong happened in the Users Form :", ex);
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = (User)bindingSourceUsers.Current;
                if (user == null)
                {
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?",
                    "Delete Confirmation ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    repository.Delete(user);
                    RefreshControls();
                }

            }
            catch (Exception ex)
            {

                throw new ApplicationException("Something wrong happened in the Users Form :", ex);
            }
        }

        private void bindingSourceUsers_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditButton_Click(null, null);
        }
    }
}
