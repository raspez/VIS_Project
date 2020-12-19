using System;
using System.Data.Entity;


namespace DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=localConnectionString")
        {
        }


        public DbSet<Bicycle> Bicycles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
