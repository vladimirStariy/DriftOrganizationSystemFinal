using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftOrganizationSystem.Domain.Viewmodels
{
    public class PilotViewModel
    {
        public uint Pilot_ID { get; set; }

        [DisplayName("Фамилия")]
        public string Surname { get; set; }
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Отчество")]
        public string Fathername { get; set; }
        [DisplayName("Возраст")]
        public int Age { get; set; }
    }
}
