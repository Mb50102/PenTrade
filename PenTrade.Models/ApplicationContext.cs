using System;
using Microsoft.EntityFrameworkCore;


namespace PenTrade.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CurrentStock> CurrentStocks { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Negotiation> Negotiations { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Merchandise> Merchandises { get; set; }
    }
}
