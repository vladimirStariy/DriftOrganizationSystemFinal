using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftOrganizationSystem.Domain.Viewmodels
{
    public class RegistrationViewModel
    {
        public uint Pilot_Id { get; set; }
        [DisplayName("Пилот")]
        public string FIO { get; set; }
        [DisplayName("Очки")]
        public double? Mark { get; set; }
        [DisplayName("Место")]
        public int? Place { get; set; }
    }
}
