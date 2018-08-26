
namespace BookATable.GUI
{
    using global::BookATable.Entities;
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    public partial class FormAddEditRestaurant : Form
    {
        private Restaurant restaurant;
        public FormAddEditRestaurant(Restaurant restaurant)
        {
            InitializeComponent();
            this.restaurant = restaurant;
        }

        private void FormAddEditRestaurant_Load(object sender, System.EventArgs e)
        {
            try
            {
                this.Text = string.Format("{0} - Book a Table", restaurant.Id > 0 ? "Edit restaurant" : "Add restaurant");

                textBoxRestaurantName.Text = restaurant.Name;
                textBoxAddress.Text = restaurant.Address;
                textBoxPhone.Text = restaurant.Phone;
                numUpDownCapacity.Value = restaurant.Capacity;
                if (restaurant.OpenHour != null && restaurant.CloseHour != null)
                {
                    dateTimePickerOpen.Value = DateTime.Parse(DateTime.Now.ToShortDateString() + " " + restaurant.OpenHour, CultureInfo.CurrentCulture);
                    dateTimePickerClose.Value = DateTime.Parse(DateTime.Now.ToShortDateString() + " " + restaurant.CloseHour, CultureInfo.CurrentCulture);
                }

            }
            catch (Exception ex)
            {

                throw new ApplicationException("Something wrong happened in the Add-Edit Restaurant Form :", ex);
            }

        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                restaurant.Name = textBoxRestaurantName.Text;
                restaurant.Address = textBoxAddress.Text;
                restaurant.Phone = textBoxPhone.Text;

                restaurant.Capacity = (int)numUpDownCapacity.Value;
                restaurant.OpenHour = dateTimePickerOpen.Value.ToString("HH:mm");
                restaurant.CloseHour = dateTimePickerClose.Value.ToString("HH:mm");

                if (string.IsNullOrEmpty(textBoxRestaurantName.Text) || string.IsNullOrEmpty(textBoxAddress.Text) || string.IsNullOrEmpty(textBoxPhone.Text))
                {
                    this.DialogResult = DialogResult.Abort;
                    MessageBox.Show("Please complete empty fields.");
                }
                else if ((int)numUpDownCapacity.Value <= 0)
                {
                    this.DialogResult = DialogResult.Abort;
                    MessageBox.Show("Capacity must be greater than zero.");
                }

            }
            catch (Exception ex)
            {

                throw new ApplicationException("Something wrong happened in the Add-Edit Restaurant Form :", ex);
            }

        }
    }
}
