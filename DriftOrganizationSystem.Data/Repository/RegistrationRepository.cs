using DriftOrganizationSystem.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftOrganizationSystem.Data.Repository
{
    public class RegistrationRepository
    {
        public void AddRegistration(Registration entity)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                _db.Registrations.Add(entity);
                _db.SaveChanges();
            }
        }

        public void EditSponsor(Registration entity)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                _db.Registrations.Update(entity);
                _db.SaveChanges();
            }
        }

        public void DeleteSponsor(int id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                var registration = _db.Registrations.Where(x => x.Registration_ID == id).FirstOrDefault();
                _db.Registrations.Remove(registration);
                _db.SaveChanges();
            }
        }

        public Registration GetById(uint id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                return _db.Registrations.Where(x => x.Registration_ID == id).FirstOrDefault();
            }
        }

        public Pilot GetPilotById(uint id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                return _db.Pilots.Where(x => x.Pilot_ID == id).FirstOrDefault();
            }
        }

        public List<Registration> GetByEventId(uint id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                return _db.Registrations.FromSql($"SELECT Registration_ID, Mark, Place, Pilot_ID, Event_ID FROM Registrations WHERE Event_ID = {id}").ToList();
            }
        }
    }
}
