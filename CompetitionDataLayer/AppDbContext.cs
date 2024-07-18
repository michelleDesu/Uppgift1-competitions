using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CompetitionDomainModel;
using Microsoft.Extensions.Configuration;



namespace CompetitionDataLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Participant> Participants { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();

                optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competition>()
                .HasMany(c => c.Participants)
                .WithOne(p => p.Competition)
                .HasForeignKey(p => p.CompetitionId);

            base.OnModelCreating(modelBuilder);

            

        }

    }
}
