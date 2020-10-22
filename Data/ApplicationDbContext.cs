using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OraCoreIdentity3.Models;

namespace OraCoreIdentity3._1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<COMPANYADDRESS> COMPANYADDRESS { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<COMPANYADDRESS>(entity =>
            {
                entity.ToTable("COMPANYADDRESS", "NAII");
                entity.HasKey(e => new { e.COMPANYID, e.MAINADDRESSESID });
            });

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
