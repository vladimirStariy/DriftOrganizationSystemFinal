using DriftOrganizationSystem.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftOrganizationSystem.Data.Repository
{
    public class OrganizatorRepository
    {
        public void AddOrg(Organizator entity)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                _db.Organizators.Add(entity);
                _db.SaveChanges();
            }
        }

        public void EditOrg(Organizator entity)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                _db.Organizators.Update(entity);
                _db.SaveChanges();
            }
        }

        public void DeleteOrg(int id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                var organizator = _db.Organizators.Where(x => x.Organizator_ID == id).FirstOrDefault();
                _db.Organizators.Remove(organizator);
                _db.SaveChanges();
            }
        }

        public Organizator GetById(uint id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                return _db.Organizators.Where(x => x.Organizator_ID == id).FirstOrDefault();
            }
        }

        public List<Organizator> GetEventOrganizators(uint event_id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                var eventOrganizators = _db.Organizators.FromSql($"SELECT Organizators.Organizator_ID as 'Organizator_ID', Organizators.Surname as 'Surname', Organizators.Name as 'Name', Organizators.FatherName as 'FatherName', Organizators.Position as 'Position' FROM Organizators INNER JOIN EventOrganizators ON Organizators.Organizator_ID = EventOrganizators.OrganizatorsOrganizator_ID INNER JOIN dbo.[Events] ON dbo.[Events].Event_ID = EventOrganizators.EventsEvent_ID WHERE Event_ID = {event_id}").ToList();
                return eventOrganizators;
            }
        }
    }
}
