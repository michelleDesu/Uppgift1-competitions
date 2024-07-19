using System;
using System.Linq;
using CompetitionDataLayer;
using CompetitionDomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddDbContext<AppDbContext>()
            .AddScoped<CompetitionDataAccessLayer>()
            .BuildServiceProvider();

        using (var scope = serviceProvider.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            SeedData(context);

            var dal = scope.ServiceProvider.GetRequiredService<CompetitionDataAccessLayer>();
            var competitions = dal.GetAllCompetitions();

            foreach (var competition in competitions)
            {
                Console.WriteLine($"Tävling: {competition.Name}");

                foreach (var participant in competition.Participants)
                {
                    Console.WriteLine($"\tDeltagare: {participant.Name}");
                }
                Console.WriteLine();
            }
        }
    }

    private static void SeedData(AppDbContext context)
    {
        var simning = new Competition { Name = "Simmning" };
        var tennis = new Competition { Name = "Tennis" };
        var dans = new Competition { Name = "Dans" };
        var fotboll = new Competition { Name = "Fotboll" };
        var esport = new Competition { Name = "E-sport" };

        context.Competitions.AddRange(simning, tennis, dans, fotboll, esport);
        context.SaveChanges();

        var participants = new[]
        {
            new Participant { Name = "Saga", CompetitionId = esport.Id },
            new Participant { Name = "Ulv", CompetitionId = esport.Id },
            new Participant { Name = "Embla", CompetitionId = esport.Id },

            new Participant { Name = "Torgny", CompetitionId = tennis.Id },

            new Participant { Name = "Gisle", CompetitionId = dans.Id },
            new Participant { Name = "Erak", CompetitionId = dans.Id },
            new Participant { Name = "Haldur", CompetitionId = dans.Id },

            new Participant { Name = "Saxe", CompetitionId = simning.Id },

            new Participant { Name = "Estrid", CompetitionId = fotboll.Id },
            new Participant { Name = "Erling", CompetitionId = fotboll.Id }
        };

        context.Participants.AddRange(participants);
        context.SaveChanges();
    }
}
