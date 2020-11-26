namespace BookATable.GUI
{
    using System;
    using System.Windows.Forms;
    using System.Globalization;

    using BookATable.Common;
    using Entities;
    using Repositories;

    public partial class FormAddEditReservation : Form
    {
        private Reservation reservation;
        private RestaurantRepository repositoryRestaurant;
        private UserRepository repositoryUser;
        private BookATableContext context;
        private const string AddEditReservationDisplay = "Add-Edit Reservation";

        public FormAddEditReservation(Reservation reservation)
        {
            InitializeComponent();
            this.context = new BookATableContext();
            this.reservation = reservation;
            this.repositoryRestaurant = new RestaurantRepository();
            this.repositoryUser = new UserRepository();
            this.RefreshControls();
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

        private void FormAddEditReservation_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = string.Format("{0} - Book a Table", reservation.Id > 0 ? "Edit reservation" : "Add reservation");

                if (reservation.ReservationTime != null)
                {
                    dateTimePicker1.Value = DateTime.Parse(reservation.ReservationTime, CultureInfo.CreateSpecificCulture("fr-FR"));
                }

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

                throw new ApplicationException(string.Format(ErrorMessages.ErrorMessageTemplate, AddEditReservationDisplay), ex);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                reservation.ReservationTime = dateTimePicker1.Value.ToString(GlobalConstants.ReservatonTimeFormat, CultureInfo.InvariantCulture);
                reservation.PeopleCount = (int)NumPeopleUpDown.Value;
                reservation.Comment = textBoxComment.Text;
                reservation.RestaurantId = ((Restaurant)this.cmbRestaurants.SelectedItem).Id;
                reservation.UserId = ((User)this.cmbUsers.SelectedItem).Id;

                if ((int)NumPeopleUpDown.Value <= 0)
                {
                    this.DialogResult = DialogResult.Abort;
                    MessageBox.Show(ErrorMessages.InvalidNumberPeople);
                }

                if (string.IsNullOrEmpty(this.textBoxComment.Text))
                {
                    DialogResult dr = MessageBox.Show(
                        InfoMessages.SaveConfirmation,
                        GlobalConstants.SaveConfirmationCaption,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Abort;
                    }
                }

                DateTime ohour = DateTime.Parse(DateTime.Now.ToShortDateString() + " " + ((Restaurant)this.cmbRestaurants.SelectedItem).OpenHour, CultureInfo.CurrentCulture);
                DateTime chour = DateTime.Parse(DateTime.Now.ToShortDateString() + " " + ((Restaurant)this.cmbRestaurants.SelectedItem).CloseHour, CultureInfo.CurrentCulture);
                DateTime rtime = DateTime.ParseExact(reservation.ReservationTime, GlobalConstants.ReservatonTimeFormat, CultureInfo.InvariantCulture);
                if (ohour > rtime || chour < rtime)
                {
                    this.DialogResult = DialogResult.Abort;
                    MessageBox.Show("Reservation time must be between " + ((Restaurant)this.cmbRestaurants.SelectedItem).OpenHour
                        + " hs. and " + ((Restaurant)this.cmbRestaurants.SelectedItem).CloseHour + " hs.", GlobalConstants.InvalidTimeCaption,
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
