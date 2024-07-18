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

            var simning = new Competition { Name = "Simmning" };
            var tennis = new Competition { Name = "Tennis" };
            var dans = new Competition { Name = "Dans" };
            var fotboll = new Competition { Name = "fotboll" };
            var esport = new Competition { Name = "E-sport" };

            modelBuilder.Entity<Competition>().HasData(
               simning,
               tennis, 
               dans, 
               fotboll, 
               esport
                );


            modelBuilder.Entity<Participant>().HasData(
                new Participant { Name = "Saga" , CompetitionId = esport.Id},
                new Participant { Name = "Ulv" , CompetitionId = esport.Id},
                new Participant { Name = "Embla" , CompetitionId = esport.Id},

                new Participant { Name = "Torgny" , CompetitionId = tennis.Id},

                new Participant { Name = "Gisle" , CompetitionId = dans.Id},
                new Participant { Name = "Erak" , CompetitionId = dans.Id},
                new Participant { Name = "Haldur" , CompetitionId = dans.Id},

                new Participant { Name = "Saxe" , CompetitionId = simning.Id},

                new Participant { Name = "Estrid" , CompetitionId = fotboll.Id},
                new Participant { Name = "Erling" , CompetitionId = fotboll.Id}
                );

        }

    }
}
