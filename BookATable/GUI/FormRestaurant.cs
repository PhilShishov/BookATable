namespace BookATable.GUI
{
    using System;
    using System.Windows.Forms;

    using BookATable.Common;
    using Entities;
    using Repositories;

    public partial class FormRestaurant : Form
    {
        private RestaurantRepository repository;
        private const string RestaurantDisplay = "Restaurant";

        public FormRestaurant(RestaurantRepository repository)
        {
            InitializeComponent();

            this.repository = repository;

            RefreshControls();
        }

        private void RefreshControls()
        {
            bindingSourceRestaurant.Clear();
            bindingSourceRestaurant.DataSource = repository.GetAll();
            dataGridViewRestaurant.DataSource = bindingSourceRestaurant;
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurant restaurant = new Restaurant();
                FormAddEditRestaurant formAddEditRestaurant = new FormAddEditRestaurant(restaurant);

                DialogResult dr = formAddEditRestaurant.ShowDialog();
                if (dr == DialogResult.Abort)
                {
                    do
                    {
                        dr = formAddEditRestaurant.ShowDialog();
                    } while (dr != DialogResult.OK && dr != DialogResult.Cancel);
                }
                if (dr == DialogResult.OK)
                {
                    repository.Insert(restaurant);
                    RefreshControls();
                }

            }
            catch (Exception ex)
            {

                throw new ApplicationException(string.Format(ErrorMessages.ErrorMessageTemplate, RestaurantDisplay), ex);
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurant restaurant = (Restaurant)bindingSourceRestaurant.Current;
                if (restaurant == null)
                {
                    return;
                }


                FormAddEditRestaurant formAddEditRestaurant = new FormAddEditRestaurant(restaurant);

                DialogResult dr = formAddEditRestaurant.ShowDialog();
                if (dr == DialogResult.Abort)
                {
                    do
                    {
                        dr = formAddEditRestaurant.ShowDialog();
                    } while (dr != DialogResult.OK && dr != DialogResult.Cancel);
                }
                if (dr == DialogResult.OK)
                {
                    repository.Update(restaurant);
                    RefreshControls();
                }

            }
            catch (Exception ex)
            {

                throw new ApplicationException(string.Format(ErrorMessages.ErrorMessageTemplate, RestaurantDisplay), ex);
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurant restaurant = (Restaurant)bindingSourceRestaurant.Current;
                if (restaurant == null)
                {
                    return;
                }

                DialogResult result = MessageBox.Show(
                    InfoMessages.DeleteConfirmation,
                    GlobalConstants.DeleteConfirmationCaption,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    repository.Delete(restaurant);
                    RefreshControls();
                }

            }
            catch (Exception ex)
            {

                throw new ApplicationException(string.Format(ErrorMessages.ErrorMessageTemplate, RestaurantDisplay), ex);
            }
        }

        private void bindingSourceRestaurant_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewRestaurant_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditButton_Click(null, null);
        }
    }
}
