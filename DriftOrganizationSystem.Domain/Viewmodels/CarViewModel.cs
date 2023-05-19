using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftOrganizationSystem.Domain.Viewmodels
{
    public class CarViewModel
    {
        public uint Car_ID { get; set; }
        public uint Pilot_ID { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }
        [DisplayName("Тип двигателя")]
        public string Engine { get; set; }
        [DisplayName("Мощность")]
        public string Power { get; set; }
        [DisplayName("Тип топлива")]
        public string FuelType { get; set; }
        [DisplayName("Вес")]
        public double Weight { get; set; }
    }
}
