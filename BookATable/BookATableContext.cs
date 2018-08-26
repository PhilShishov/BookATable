
namespace BookATable
{
    using System.Data.Entity;
    using global::BookATable.Entities;

    public class BookATableContext : DbContext
    {
        public BookATableContext() : base("BookATableDb1")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
