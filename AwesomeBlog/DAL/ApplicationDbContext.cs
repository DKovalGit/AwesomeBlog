using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AwesomeBlog.DAL.Models;
using Microsoft.AspNetCore.Identity;

namespace AwesomeBlog.DAL
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, string>
    {
        public DbSet<UserPosts> UserPosts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<IdentityUser>().ToTable("Users");
            
            modelBuilder.Entity<User>()
                .ToTable("Users");

            modelBuilder.Entity<Role>()
                .ToTable("Roles");

            modelBuilder.Entity<IdentityUserRole<string>>()
                .ToTable("UserRoles");

        }
    }
}
