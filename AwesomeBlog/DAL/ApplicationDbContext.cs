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
        public DbSet<UserPost> UserPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTag> PostTags { get; set; }

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

            // уникальный индекс для UserPostId, TagId таблицы PostTags
            //modelBuilder.Entity<PostTag>()
            //    .HasIndex(u => new { u.UserPostId, u.TagId }).IsUnique()
            //    .HasDatabaseName("UQ_PostTag");
        }
    }
}
