using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftOrganizationSystem.Domain.Viewmodels
{
    public class SponsorViewModel
    {
        public uint Sponsor_ID { get; set; }
        [DisplayName("Наименование")]
        public string SponsorName { get; set; }
        [DisplayName("Контактное лицо")]
        public string ContactFace { get; set; }
    }
}
