using System.ComponentModel.DataAnnotations.Schema;

namespace DriftOrganizationSystem.Domain.Entity
{
    public class Achievement
    {
        public uint Achievement_ID { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public string Car { get; set; }
        public string Year { get; set; }
        public string Prize { get; set; }

        public uint Pilot_ID { get; set; }
        [ForeignKey("Pilot_ID")]
        public virtual Pilot Pilot { get; set; }
    }
}
