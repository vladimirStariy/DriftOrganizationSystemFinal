using DriftOrganizationSystem.Data.Repository;
using DriftOrganizationSystem.Domain.Entity;

namespace DriftOrganizationSystem.Service.Services
{
    public class OrganizatorService
    {
        OrganizatorRepository organizatorRepository = new OrganizatorRepository();

        public void Create(Organizator entity)
        {

        }

        public Organizator GetOrganizatorById(uint id)
        {
            return organizatorRepository.GetById(id);
        }

    }
}
