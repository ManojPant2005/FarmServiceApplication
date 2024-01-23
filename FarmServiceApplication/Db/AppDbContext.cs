using FarmServiceApplication.Data;
using Microsoft.EntityFrameworkCore;

namespace FarmServiceApplication.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
         
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expense>().HasNoKey();
        }

        public DbSet<Farm> Farms { get; set; }
        public DbSet<Expense> Expenses { get; set; }   
        public DbSet<Income> Incomes { get; set; }  
        public DbSet<Crop> Crops { get; set; }
    }
}
