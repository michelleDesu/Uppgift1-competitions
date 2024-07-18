using CompetitionDataLayer;
using CompetitionDomainModel;
using Microsoft.EntityFrameworkCore;

namespace CompetitionConsoleApp.Tests
{
    public class CompetitionDataAccessLayerTests
    {
        [Fact]
        public void GetCompetitionById_ReturnsCorrectCompetition()
        {
            // Skapa en ny konfiguration för DbContext med InMemory-databas
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "InMemoryDatabase") // Använd en in-memory-databas för snabba tester
                .Options;

            // Använd using så att kontexten stängs korrekt efter användning
            using (var context = new AppDbContext(options))
            {
                // Lägg till testdata i databasen
                var expectedCompetitionId = Guid.NewGuid();
                var competition = new Competition { Id = expectedCompetitionId, Name = "Test Competition" };
                context.Competitions.Add(competition);
                context.SaveChanges();

                // Skapa en instans av data access layer
                var dataAccessLayer = new CompetitionDataAccessLayer(context);

                // Hämta tävlingen med det angivna ID:t
                var result = dataAccessLayer.GetCompetitionById(expectedCompetitionId);

                // Kontrollera att resultatet inte är null och att ID:t är korrekt
                Assert.NotNull(result);
                Assert.Equal(expectedCompetitionId, result.Id);
                Assert.Equal("Test Competition", result.Name);
            }
        }
    }
}
