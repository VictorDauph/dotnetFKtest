global using Microsoft.EntityFrameworkCore;
using FKTest.models;
using FKTest.config;


namespace FKTest.Context
{
    public class DataContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //la connection string ne doit pes être codée en dur.
            optionsBuilder.UseSqlServer(ConnectionString.GetString());
        }

    }
}
