using System.ComponentModel.DataAnnotations.Schema;

namespace DriftOrganizationSystem.Domain.Entity
{
    public class Car
    {
        public uint Car_ID { get; set; }
        public string Name { get; set; }
        public string EngineType { get; set; }
        public string Power { get; set; }
        public string FuelType { get; set; }
        public double Weight { get; set; }

        public uint Pilot_ID { get; set; }
        [ForeignKey("Pilot_ID")]
        public virtual Pilot Pilot { get; set; }
    }
}
