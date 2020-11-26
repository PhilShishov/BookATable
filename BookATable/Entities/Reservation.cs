namespace BookATable.Entities
{
    using System.ComponentModel;

    public class Reservation : BaseEntity
    {
        [Browsable(false)]
        [DisplayName("UserId")]
        public int UserId { get; set; }

        [Browsable(false)]
        [DisplayName("RestaurantId")]
        public int RestaurantId { get; set; }
        
        public virtual User User { get; set; }
        
        public virtual Restaurant Restaurant { get; set; }

        [DisplayName("PeopleCount")]
        public int PeopleCount { get; set; }

        [DisplayName("Comment")]
        public string Comment { get; set; }

        [DisplayName("ReservationTime")]
        public string ReservationTime { get; set; }
        
    }
}
