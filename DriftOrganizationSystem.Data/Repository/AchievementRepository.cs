using DriftOrganizationSystem.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftOrganizationSystem.Data.Repository
{
    public class AchievementRepository
    {
        public void AddAchievement(Achievement entity)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                _db.Achievements.Add(entity);
                _db.SaveChanges();
            }
        }

        public void EditAchievement(Achievement entity)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                _db.Achievements.Update(entity);
                _db.SaveChanges();
            }
        }

        public void DeleteAchievement(int id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                var achievement = _db.Achievements.Where(x => x.Achievement_ID == id).FirstOrDefault();
                _db.Achievements.Remove(achievement);
                _db.SaveChanges();
            }
        }

        public Achievement GetById(uint id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                return _db.Achievements.Where(x => x.Achievement_ID == id).FirstOrDefault();
            }
        }
    }
}
