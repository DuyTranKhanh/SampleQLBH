using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuanLiBanHang_Group1.Models;

namespace QuanLiBanHang_Group1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Products> Products{ get; set; }
        public DbSet<InvoiceDetails> InvoiceDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InvoiceDetails>()
                .HasKey(pt => new { pt.InvoiceId, pt.ProID });

            modelBuilder.Entity<InvoiceDetails>()
                .HasOne(pt => pt.Invoice)
                .WithMany(p => p.InvoiceDetails)
                .HasForeignKey(pt => pt.InvoiceId);

            modelBuilder.Entity<InvoiceDetails>()
                .HasOne(pt => pt.Products)
                .WithMany(t => t.InvoiceDetails)
                .HasForeignKey(pt => pt.ProID);
            base.OnModelCreating(modelBuilder);


        }
   
    }
}
