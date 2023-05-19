using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftOrganizationSystem.Domain.Viewmodels
{
    public class OrganizatorViewModel
    {
        public uint Organizator_ID { get; set; }
        [DisplayName("Фамилия")]
        public string Surname { get; set; }
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Отчество")]
        public string FatherName { get; set; }
        [DisplayName("Должность")]
        public string Position { get; set; }
    }
}
