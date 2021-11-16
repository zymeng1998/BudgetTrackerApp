using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{

    public class BudgetTrackerDbContext : DbContext
    {
        public BudgetTrackerDbContext(DbContextOptions<BudgetTrackerDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>(ConfigureUser);
            modelBuilder.Entity<Expenditure>(ConfigureExpenditure);
            modelBuilder.Entity<Income>(ConfigureIncome);
        }
        private void ConfigureUser(EntityTypeBuilder<User> builder) {
            builder.Property(u => u.Email).HasMaxLength(50);
            builder.Property(u => u.Password).HasMaxLength(10);
            builder.Property(u => u.FullName).HasMaxLength(50);
            builder.Property(u => u.JoinedOn).HasDefaultValueSql("getdate()");
        }
        private void ConfigureExpenditure(EntityTypeBuilder<Expenditure> builder)
        {
            builder.Property(u => u.Description).HasMaxLength(100);
            builder.Property(u => u.Remarks).HasMaxLength(500);
            builder.Property(u => u.ExpDate).HasDefaultValueSql("getdate()");
        }
        private void ConfigureIncome(EntityTypeBuilder<Income> builder)
        {
            builder.Property(u => u.Description).HasMaxLength(100);
            builder.Property(u => u.Remarks).HasMaxLength(500);
            builder.Property(u => u.IncomeDate).HasDefaultValueSql("getdate()");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expenditure> Expenditures { get; set; }
    }
}
