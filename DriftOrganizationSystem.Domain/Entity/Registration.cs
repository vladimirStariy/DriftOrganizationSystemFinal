using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DriftOrganizationSystem.Domain.Entity
{
    public class Registration
    {
        public uint Registration_ID { get; set; }
        public double? Mark { get; set; }
        public int? Place { get; set; }
        public uint Pilot_ID { get; set; }
        [ForeignKey("Pilot_ID")]
        public virtual Pilot Pilot { get; set; }
        public uint Event_ID { get; set; }
        [ForeignKey("Event_ID")]
        public virtual Event Event { get; set; }
    }
}
