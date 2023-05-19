using DriftOrganizationSystem.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftOrganizationSystem.Domain.Viewmodels
{
    public class EventViewModel
    {
        public uint Event_ID { get; set; }
        [DisplayName ("Название мероприятия")]
        public string Event_Name { get; set; }
        [DisplayName("Дата мероприятия")]
        public DateTime Event_Date { get; set; }
        [DisplayName("Место проведения")]
        public string Place { get; set; }
        public List<Sponsor> Sponsors { get; set; }
        public List<Judge> Judges { get; set; }
        public List<Organizator> Organizators { get; set; }
        public List<Registration> Registrations { get; set; }
    }
}
