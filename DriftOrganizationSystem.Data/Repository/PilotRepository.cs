using DriftOrganizationSystem.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriftOrganizationSystem.Data.Repository
{
    public class PilotRepository
    {
        public void AddPilot(Pilot entity)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                _db.Pilots.Add(entity);
                _db.SaveChanges();
            }
        }

        public void EditPilot(Pilot entity)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                _db.Pilots.Update(entity);
                _db.SaveChanges();
            }
        }

        public void DeletePilot(int id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                var pilot = _db.Pilots.Where(x => x.Pilot_ID == id).FirstOrDefault();
                _db.Pilots.Remove(pilot);
                _db.SaveChanges();
            }
        }

        public List<Pilot> GetPilots()
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                return _db.Pilots.ToList();
            }
        }

        public List<Car> GetPilotCars(int id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                return _db.Cars.Where(x => x.Pilot_ID == id).ToList();
            }
        }

        public List<Achievement> GetPilotAchievements(int id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                return _db.Achievements.Where(x => x.Pilot_ID == id).ToList();
            }
        }

        public Pilot GetById(uint id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                return _db.Pilots.Where(x => x.Pilot_ID == id).FirstOrDefault();
            }
        }
    }
}
