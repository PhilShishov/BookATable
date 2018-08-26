
namespace BookATable.GUI
{
    using global::BookATable.Entities;
    using global::BookATable.Repositories;
    using System;
    using System.Windows.Forms;
    using System.Globalization;

    public partial class FormAddEditReservation : Form
    {
        private Reservation reservation;

        private RestaurantRepository repositoryRestaurant;

        private UserRepository repositoryUser;
        global::BookATable.BookATableContext context;

        public FormAddEditReservation(Reservation reservation)
        {
            InitializeComponent();

            context = new BookATableContext();

            this.reservation = reservation;

            repositoryRestaurant = new RestaurantRepository();
            repositoryUser = new UserRepository();

            RefreshControls();
        }

        private void RefreshControls()
        {
            cmbUsers.ValueMember = "Name";
            cmbRestaurants.ValueMember = "Name";

            bindingSourceRestaurant.Clear();
            bindingSourceRestaurant.DataSource = repositoryRestaurant.GetAll();
            cmbRestaurants.DataSource = bindingSourceRestaurant;

            bindingSourceUser.Clear();
            bindingSourceUser.DataSource = repositoryUser.GetAll();
            cmbUsers.DataSource = bindingSourceUser;

        }

        private void FormAddEditReservation_Load(object sender, System.EventArgs e)
        {
            try
            {
                this.Text = string.Format("{0} - Book a Table", reservation.Id > 0 ? "Edit reservation" : "Add reservation");

                if (reservation.ReservationTime != null)
                    dateTimePicker1.Value = DateTime.Parse(reservation.ReservationTime, CultureInfo.CreateSpecificCulture("fr-FR"));

                NumPeopleUpDown.Value = reservation.PeopleCount;
                textBoxComment.Text = reservation.Comment;

                if (reservation.User != null && reservation.Restaurant != null)
                {
                    this.cmbUsers.SelectedValue = reservation.User.Name;
                    this.cmbRestaurants.SelectedValue = reservation.Restaurant.Name;
                }

            }
            catch (Exception ex)
            {

                throw new ApplicationException("Something wrong happened in the Add-Edit Reservation Form :", ex);
            }
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                reservation.ReservationTime = dateTimePicker1.Value.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                reservation.PeopleCount = (int)NumPeopleUpDown.Value;
                reservation.Comment = textBoxComment.Text;
                reservation.RestaurantId = ((Restaurant)this.cmbRestaurants.SelectedItem).Id;
                reservation.UserId = ((User)this.cmbUsers.SelectedItem).Id;

                if ((int)NumPeopleUpDown.Value <= 0)
                {
                    this.DialogResult = DialogResult.Abort;
                    MessageBox.Show("Number of people must be greater than zero.");
                }

                if (string.IsNullOrEmpty(this.textBoxComment.Text))
                {
                    DialogResult dr = MessageBox.Show("Comments are empty, save it anyway?", "Save confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                        this.DialogResult = DialogResult.OK;
                    else
                        this.DialogResult = DialogResult.Abort;
                }

                DateTime ohour = DateTime.Parse(DateTime.Now.ToShortDateString() + " " + ((Restaurant)this.cmbRestaurants.SelectedItem).OpenHour, CultureInfo.CurrentCulture);
                DateTime chour = DateTime.Parse(DateTime.Now.ToShortDateString() + " " + ((Restaurant)this.cmbRestaurants.SelectedItem).CloseHour, CultureInfo.CurrentCulture);
                DateTime rtime = DateTime.ParseExact(reservation.ReservationTime, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                if (ohour > rtime || chour < rtime)
                {
                    this.DialogResult = DialogResult.Abort;
                    MessageBox.Show("Reservation time must be between " + ((Restaurant)this.cmbRestaurants.SelectedItem).OpenHour
                        + " hs. and " + ((Restaurant)this.cmbRestaurants.SelectedItem).CloseHour + " hs.", "Invalid reservation time",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (FormatException)
            {
                throw new ApplicationException("CultureInfo method is invalid");
            }

        }
    }
}
