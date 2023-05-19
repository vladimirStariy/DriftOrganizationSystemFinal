using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftOrganizationSystem.Domain.Viewmodels
{
    public class AchievementViewModel
    {
        public uint Achievement_ID { get; set; }
        public uint Pilot_ID { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Место проведения")]
        public string Place { get; set; }
        [DisplayName("Автомобиль")]
        public string Car { get; set; }
        [DisplayName("Год")]
        public string Year { get; set; }
        [DisplayName("Призовое место")]
        public string Prize { get; set; }
    }
}
