using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinode_RateApplicationWebAPI.Models
{
    public class RatingAppContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Skills> Skills { get; set; }

        public RatingAppContext(DbContextOptions<RatingAppContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Profile
            modelBuilder.Entity<Profile>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Profile>()
                .Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<Profile>()
                .Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<Profile>()
                .Ignore(p => p.FullName);
            #endregion

            #region Skills
            modelBuilder.Entity<Skills>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<Skills>()
                .Property(p => p.Skill)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<Skills>()
                .HasOne(s => s.Profile)
                .WithMany(s => s.Skills)
                .HasForeignKey(s => s.ProfileId);
            #endregion
        }
    }
}
