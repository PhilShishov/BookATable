namespace BookATable.GUI
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    using BookATable.Common;
    using Entities;

    public partial class FormAddEditRestaurant : Form
    {
        private Restaurant restaurant;
        private const string AddEditRestaurantDisplay = "Add-Edit Restaurant";

        public FormAddEditRestaurant(Restaurant restaurant)
        {
            InitializeComponent();
            this.restaurant = restaurant;
        }

        private void FormAddEditRestaurant_Load(object sender, EventArgs e)
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

                throw new ApplicationException(string.Format(ErrorMessages.ErrorMessageTemplate, AddEditRestaurantDisplay), ex);
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                restaurant.Name = textBoxRestaurantName.Text;
                restaurant.Address = textBoxAddress.Text;
                restaurant.Phone = textBoxPhone.Text;

                restaurant.Capacity = (int)numUpDownCapacity.Value;
                restaurant.OpenHour = dateTimePickerOpen.Value.ToString(GlobalConstants.HourFormat);
                restaurant.CloseHour = dateTimePickerClose.Value.ToString(GlobalConstants.HourFormat);

                if (string.IsNullOrEmpty(textBoxRestaurantName.Text) || string.IsNullOrEmpty(textBoxAddress.Text) || string.IsNullOrEmpty(textBoxPhone.Text))
                {
                    this.DialogResult = DialogResult.Abort;
                    MessageBox.Show(ErrorMessages.EmptyInputFields);
                }
                else if ((int)numUpDownCapacity.Value <= 0)
                {
                    this.DialogResult = DialogResult.Abort;
                    MessageBox.Show(ErrorMessages.InvalidCapacity);
                }

            }
            catch (Exception ex)
            {

                throw new ApplicationException(string.Format(ErrorMessages.ErrorMessageTemplate, AddEditRestaurantDisplay), ex);
            }

        }
    }
}
