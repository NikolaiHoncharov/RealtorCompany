namespace RealtorCompany.Database
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RealtorContext : DbContext
    {
        public RealtorContext()
            : base("name=RealtorContext")
        {
        }

        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

    }

}