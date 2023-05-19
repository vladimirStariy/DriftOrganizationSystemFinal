using DriftOrganizationSystem.Data.Repository;
using DriftOrganizationSystem.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftOrganizationSystem.Service.Services
{
    public class RegistrationService
    {
        RegistrationRepository registrationRepository = new RegistrationRepository();
        
        public Pilot GetPilotById(uint id)
        {
            return registrationRepository.GetPilotById(id);
        }
    }
}
