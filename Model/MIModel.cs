using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication2.Model
{
    public partial class MIModel : DbContext
    {
        public MIModel()
            : base("name=ConnString")
        {
        }

        public virtual DbSet<StorePurchasesView> StorePurchasesView { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StorePurchasesView>()
                .Property(e => e.StoreName)
                .IsUnicode(false);

            modelBuilder.Entity<StorePurchasesView>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<StorePurchasesView>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<StorePurchasesView>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<StorePurchasesView>()
                .Property(e => e.ItemDescription)
                .IsUnicode(false);

            modelBuilder.Entity<StorePurchasesView>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<StorePurchasesView>()
                .Property(e => e.UnitPriceUSD)
                .HasPrecision(9, 2);
        }
    }
}
