namespace DriftOrganizationSystem.Domain.Entity
{
    public class Event
    {
        public uint Event_ID { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string Place { get; set; }
        public virtual ICollection<Organizator> Organizators { get; set; }
        public virtual ICollection<Sponsor> Sponsors { get; set; }
        public virtual ICollection<Judge> Judges { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
