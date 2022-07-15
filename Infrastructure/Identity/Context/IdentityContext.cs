
using Infrastructure.Identity.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Identity.Context
{
    public class IdentityContext : IdentityDbContext<ApplicationUser>
    {
        
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("IdentityConnection");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("Identity");

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "User");
            });

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable("Email");
            });

            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });

            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable("Password");
            });

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable("HashedPassword");
            });

            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });
        }
    }
}

