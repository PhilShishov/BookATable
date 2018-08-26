namespace BookATable.GUI
{
    using global::BookATable.Entities;
    using global::BookATable.Repositories;
    using System;
    using System.Windows.Forms;

    public partial class FormRestaurant : Form
    {

        private RestaurantRepository repository;

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

                throw new ApplicationException("Something wrong happened in the Restaurant Form :", ex);
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

                throw new ApplicationException("Something wrong happened in the Restaurant Form :", ex);
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

                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?",
                    "Delete Confirmation ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    repository.Delete(restaurant);
                    RefreshControls();
                }

            }
            catch (Exception ex)
            {

                throw new ApplicationException("Something wrong happened in the Restaurant Form :", ex);
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
