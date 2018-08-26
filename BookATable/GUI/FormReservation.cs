namespace BookATable.GUI
{
    using global::BookATable.Entities;
    using global::BookATable.Repositories;
    using System;
    using System.Windows.Forms;

    public partial class FormReservation : Form
    {
        private ReservationRepository repository;

        public FormReservation(ReservationRepository repository)
        {
            InitializeComponent();

            this.repository = repository;

            RefreshControls();
        }

        private void RefreshControls()
        {
            bindingSourceReserve.Clear();
            bindingSourceReserve.DataSource = repository.GetAll();
            dataGridViewReserve.DataSource = bindingSourceReserve;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Reservation reservation = new Reservation();
                FormAddEditReservation formAddReserve = new FormAddEditReservation(reservation);

                DialogResult dr = formAddReserve.ShowDialog();
                if (dr == DialogResult.Abort)
                {
                    do
                    {
                        dr = formAddReserve.ShowDialog();
                    } while (dr != DialogResult.OK && dr != DialogResult.Cancel);
                }
                if (dr == DialogResult.OK)
                {
                    repository.Insert(reservation);
                    RefreshControls();
                }

            }
            catch (Exception ex)
            {

                throw new ApplicationException("Something wrong happened in the Reservation Form :", ex);
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                Reservation reservation = (Reservation)bindingSourceReserve.Current;
                if (reservation == null)
                {
                    return;
                }

                FormAddEditReservation formEditReserve = new FormAddEditReservation(reservation);

                DialogResult dr = formEditReserve.ShowDialog();
                if (dr == DialogResult.Abort)
                {
                    do
                    {
                        dr = formEditReserve.ShowDialog();
                    } while (dr != DialogResult.OK && dr != DialogResult.Cancel);
                }
                if (dr == DialogResult.OK)
                {
                    repository.Update(reservation);
                    RefreshControls();
                }

            }
            catch (Exception ex)
            {

                throw new ApplicationException("Something wrong happened in the Reservation Form :", ex);
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Reservation reservation = (Reservation)bindingSourceReserve.Current;
                if (reservation == null)
                {
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?",
                    "Delete Confirmation ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    repository.Delete(reservation);
                    RefreshControls();
                }

            }
            catch (Exception ex)
            {

                throw new ApplicationException("Something wrong happened in the Reservation Form :", ex);
            }
        }

        private void bindingSourceReserve_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void dataGridViewReserve_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditButton_Click(null, null);
        }
    }
}
