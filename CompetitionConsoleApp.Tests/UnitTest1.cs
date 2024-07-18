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
            // Create a new configuration for DbContext using an in-memory database
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "InMemoryDatabase") // Use an in-memory database for fast testing
                .Options;

            // Use 'using' to ensure proper disposal of the context after use
            using (var context = new AppDbContext(options))
            {
                context.Database.EnsureDeleted(); // Clean the database
                context.Database.EnsureCreated(); // create a new empty database
                // Add test data to the database
                var expectedCompetitionId = Guid.NewGuid();
                var competition = new Competition { Id = expectedCompetitionId, Name = "Test Competition" };
                context.Competitions.Add(competition);
                context.SaveChanges();

                // Create an instance of the data access layer
                var dataAccessLayer = new CompetitionDataAccessLayer(context);

                // Retrieve the competition with the specified ID
                var result = dataAccessLayer.GetCompetitionById(expectedCompetitionId);

                // Assert that the result is not null and that the ID and name are correct
                Assert.NotNull(result);
                Assert.Equal(expectedCompetitionId, result.Id);
                Assert.Equal("Test Competition", result.Name);
                context.Database.EnsureDeleted(); // Clean the database
            }

        }

        [Fact]
        public void GetAllCompetitions_ReturnsAllCompetitions()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "InMemoryDatabase")
                .Options;

            using (var context = new AppDbContext(options))
            {
                context.ChangeTracker.Clear();
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var competitions = new[]
                {
            new Competition { Id = Guid.NewGuid(), Name = "Simning" },
            new Competition { Id = Guid.NewGuid(), Name = "Tennis" },
            new Competition { Id = Guid.NewGuid(), Name = "Dans" }
        };
                context.Competitions.AddRange(competitions);
                context.SaveChanges();
            }

            using (var context = new AppDbContext(options))
            {
                var dataAccessLayer = new CompetitionDataAccessLayer(context);

                // Perform the test: retrieve all competitions
                var result = dataAccessLayer.GetAllCompetitions().ToList();

                // Logging to debug
                Console.WriteLine($"Number of competitions retrieved: {result.Count}");
                foreach (var competition in result)
                {
                    Console.WriteLine($"Competition Name: {competition.Name}");
                }

                // Assert: Check that the number of competitions is correct
                Assert.Equal(3, result.Count);

                // Example of additional assertions:
                Assert.Contains(result, c => c.Name == "Simning");
                Assert.Contains(result, c => c.Name == "Tennis");
                Assert.Contains(result, c => c.Name == "Dans");

            }
        }
    }
}
