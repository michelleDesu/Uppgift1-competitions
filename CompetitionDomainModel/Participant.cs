namespace CompetitionDomainModel
{
    public class Participant
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty; // Empty but not null
        public Guid CompetitionId { get; set; }
        public Competition Competition { get; set; } = null!; // initialized with a standard value.


        public Participant() {
            Id = Guid.NewGuid();
        }

        public Participant(string name, Competition competition)
        {
            Id = Guid.NewGuid();
            Name = name;
            Competition = competition;
            CompetitionId = competition.Id;
        }
    }

}

