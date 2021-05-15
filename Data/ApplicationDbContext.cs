using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WeightTracker.DomainModels;

namespace WeightTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<WeightRecord> WeightRecords { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //This call ensures all the default Identity definitions happen
            base.OnModelCreating(builder);
            
            //Profile
            builder.Entity<Profile>().ToTable("Profile");
            builder.Entity<Profile>().HasMany(wr => wr.WeightRecords)
                .WithOne(p => p.Profile)
                .HasForeignKey(wr => wr.ProfileId);
            builder.Entity<Profile>().HasOne(p => p.User)
                .WithOne(u => u.Profile)
                .HasForeignKey<ApplicationUser>(x => x.ProfileId);

            //WeightRecord
            builder.Entity<WeightRecord>().ToTable("WeightRecord");
            builder.Entity<WeightRecord>().HasOne(p => p.Profile)
                .WithMany(wr => wr.WeightRecords);

            //Application user
            builder.Entity<ApplicationUser>().HasOne(u => u.Profile)
                .WithOne(p => p.User)
                .HasForeignKey<Profile>(p => p.UserId);
        }
    }
}