namespace BookATable.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel;

    public class Restaurant : BaseEntity
    {
        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }

        [DisplayName("Phone")]
        public string Phone { get; set; }

        [DisplayName("Capacity")]
        public int Capacity { get; set; }

        [DisplayName("OpenHour")]
        public string OpenHour { get; set; }

        [DisplayName("CloseHour")]
        public string CloseHour { get; set; }

        [DisplayName("Reservations")]
        public List<Reservation> Reservations { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
