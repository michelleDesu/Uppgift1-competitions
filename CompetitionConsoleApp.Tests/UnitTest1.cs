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
            // Skapa en ny konfiguration f�r DbContext med InMemory-databas
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "InMemoryDatabase") // Anv�nd en in-memory-databas f�r snabba tester
                .Options;

            // Anv�nd using s� att kontexten st�ngs korrekt efter anv�ndning
            using (var context = new AppDbContext(options))
            {
                // L�gg till testdata i databasen
                var expectedCompetitionId = Guid.NewGuid();
                var competition = new Competition { Id = expectedCompetitionId, Name = "Test Competition" };
                context.Competitions.Add(competition);
                context.SaveChanges();

                // Skapa en instans av data access layer
                var dataAccessLayer = new CompetitionDataAccessLayer(context);

                // H�mta t�vlingen med det angivna ID:t
                var result = dataAccessLayer.GetCompetitionById(expectedCompetitionId);

                // Kontrollera att resultatet inte �r null och att ID:t �r korrekt
                Assert.NotNull(result);
                Assert.Equal(expectedCompetitionId, result.Id);
                Assert.Equal("Test Competition", result.Name);
            }
        }
    }
}
