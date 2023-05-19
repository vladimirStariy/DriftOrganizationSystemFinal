using DriftOrganizationSystem.Data.Repository;
using DriftOrganizationSystem.Domain.Entity;
using DriftOrganizationSystem.Domain.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftOrganizationSystem.Service.Services
{
    public class AchievementService
    {
        AchievementRepository _achievementRepository = new AchievementRepository();

        public void Create(AchievementViewModel model)
        {
            var achievement = new Achievement()
            {
                Name = model.Name,
                Place = model.Place,
                Car = model.Car,
                Year = model.Year,
                Prize = model.Prize,
                Pilot_ID = model.Pilot_ID
            };
            _achievementRepository.AddAchievement(achievement);
        }
        public void Edit(AchievementViewModel model)
        {
            var achievement = new Achievement()
            {
                Achievement_ID = model.Achievement_ID,
                Name = model.Name,
                Place = model.Place,
                Car = model.Car,
                Year = model.Year,
                Prize = model.Prize,
                Pilot_ID = model.Pilot_ID
            };
            _achievementRepository.EditAchievement(achievement);
        }
        public void Delete(int id)
        {
            _achievementRepository.DeleteAchievement(id);
        }
        public Achievement GetById(uint id)
        {
            return _achievementRepository.GetById(id);
        }
    }
}
