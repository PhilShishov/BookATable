namespace BookATable.Entities
{
    using System.ComponentModel;

    public class BaseEntity
    {
        [Browsable(false)]
        public int Id { get; set; }
    }
}
