using CompetitionDataLayer;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {


        var serviceProvider = new ServiceCollection()
            .AddDbContext<AppDbContext>()
            .AddScoped<CompetitionDataAccessLayer>()
            .BuildServiceProvider();
        
        
        //Correctly freeing recources after use 
        using (var scope = serviceProvider.CreateScope())
        {
            //get an instance of the Data Access Layer, DAL in short
            var dal = scope.ServiceProvider.GetRequiredService<CompetitionDataAccessLayer>();

            var competitions = dal.GetAllCompetitions();

            foreach (var competition in competitions)
            {
                Console.WriteLine($"Tävling: {competition.Name}");
                
                foreach (var participant in competition.Participants)
                {
                    Console.WriteLine($"Deltagare: {participant.Name}");
                }

            }
        }
    }

}
