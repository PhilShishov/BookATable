namespace BookATable.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel;

    public class User : BaseEntity
    {
        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Password")]
        public string Password { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Phone")]
        public string Phone { get; set; }

        [DisplayName("IsAdmin")]
        public bool IsAdmin { get; set; }

        public virtual List<Reservation> Reservation { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
