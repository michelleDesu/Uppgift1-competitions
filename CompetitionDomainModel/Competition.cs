namespace CompetitionDomainModel
{
    public class Competition
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = String.Empty; //Name can be empty but not null

        public ICollection<Participant> Participants { get; set; } = new List<Participant>();
    }
}
