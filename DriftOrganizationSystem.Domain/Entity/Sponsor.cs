namespace DriftOrganizationSystem.Domain.Entity
{
    public class Sponsor
    {
        public uint Sponsor_ID { get; set; }
        public string SponsorName { get; set; }
        public string ContactFace { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
