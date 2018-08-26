
namespace BookATable.GUI
{
    using global::BookATable.Repositories;
    using System;
    using System.Windows.Forms;

    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void usersMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormUsers formUsers = new FormUsers(new UserRepository());
                formUsers.MdiParent = this;
                formUsers.Show();

            }
            catch (Exception ex)
            {

                throw new ApplicationException("Something wrong happened in the Main Menu Form :", ex);
            }

        }

        private void restaurantsMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormRestaurant formRestaurant = new FormRestaurant(new RestaurantRepository());
                formRestaurant.MdiParent = this;
                formRestaurant.Show();

            }
            catch (Exception ex)
            {

                throw new ApplicationException("Something wrong happened in the Main Menu Form :", ex);
            }
        }

        private void reservationsMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormReservation formReserve = new FormReservation(new ReservationRepository());
                formReserve.MdiParent = this;
                formReserve.Show();

            }
            catch (Exception ex)
            {

                throw new ApplicationException("Something wrong happened in the Main Menu Form :", ex);
            }
        }
    }
}
