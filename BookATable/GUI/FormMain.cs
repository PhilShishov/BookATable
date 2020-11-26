namespace BookATable.GUI
{
    using System;
    using System.Windows.Forms;

    using BookATable.Common;
    using Repositories;

    public partial class FormMain : Form
    {
        private const string MainMenuFormMessageDisplay = "Main Menu Form";

        public FormMain()
        {
            InitializeComponent();
        }

        private void usersMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormUser formUsers = new FormUser(new UserRepository());
                formUsers.MdiParent = this;
                formUsers.Show();

            }
            catch (Exception ex)
            {

                throw new ApplicationException(string.Format(ErrorMessages.ErrorMessageTemplate, MainMenuFormMessageDisplay), ex);
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

                throw new ApplicationException(string.Format(ErrorMessages.ErrorMessageTemplate, MainMenuFormMessageDisplay), ex);
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

                throw new ApplicationException(string.Format(ErrorMessages.ErrorMessageTemplate, MainMenuFormMessageDisplay), ex);
            }
        }
    }
}
