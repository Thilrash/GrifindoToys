using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GrifindoToys
{
    public partial class DBModels : DbContext
    {
        public DBModels()
            : base("name=DBModels")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.MonthlySalary)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee>()
                .Property(e => e.OverTimeRatesHourly)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Allowances)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee>()
                .Property(e => e.TwoMonthsSalary)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee>()
                .Property(e => e.NoPayValue)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee>()
                .Property(e => e.BasePayValue)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee>()
                .Property(e => e.GrossPay)
                .HasPrecision(18, 0);
        }
    }
}
