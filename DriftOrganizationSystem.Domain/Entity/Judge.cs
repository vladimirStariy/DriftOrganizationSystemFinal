namespace DriftOrganizationSystem.Domain.Entity
{
    public class Judge
    {
        public uint Judge_ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
