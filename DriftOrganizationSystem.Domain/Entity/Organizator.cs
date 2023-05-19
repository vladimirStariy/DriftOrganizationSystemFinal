namespace DriftOrganizationSystem.Domain.Entity
{
    public class Organizator
    {
        public uint Organizator_ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Position { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
