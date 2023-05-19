using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftOrganizationSystem.Domain.Viewmodels
{
    public class JudgeViewModel
    {
        public uint Judge_ID { get; set; }
        [Display(Name="Фамилия")]
        public string Surname { get; set; }
        [Display(Name = "Имя")]
        public string Name { get; set; }
        [Display(Name = "Отчество")]
        public string FatherName { get; set; }
    }
}
