using DriftOrganizationSystem.Data;
using DriftOrganizationSystem.Data.Repository;
using DriftOrganizationSystem.Domain.Entity;
using DriftOrganizationSystem.Domain.Enum;
using DriftOrganizationSystem.Domain.Response;
using DriftOrganizationSystem.Domain.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftOrganizationSystem.Service.Services
{
    public class PilotService
    {
        PilotRepository _pilotRepository = new PilotRepository();

        public void Create(PilotViewModel model)
        {
            var pilot = new Pilot()
            {
                Surname = model.Surname,
                Name = model.Name,
                Fathername = model.Fathername,
                Age = model.Age
            };
            _pilotRepository.AddPilot(pilot);
        }

        public void Edit(PilotViewModel model)
        {
            var pilot = new Pilot()
            {
                Pilot_ID = model.Pilot_ID,
                Surname = model.Surname,
                Name = model.Name,
                Fathername = model.Fathername,
                Age = model.Age
            };

            _pilotRepository.EditPilot(pilot);
        }

        public void Delete(int id)
        {
            _pilotRepository.DeletePilot(id);
        }

        public List<PilotViewModel> GetPilots()
        {
            List<PilotViewModel> pilotsView = new List<PilotViewModel>();
            foreach (var item in _pilotRepository.GetPilots())
            {
                PilotViewModel model = new PilotViewModel();
                model.Pilot_ID = item.Pilot_ID;
                model.Surname = item.Surname;
                model.Name = item.Name;
                model.Fathername = item.Fathername;
                model.Age = item.Age;
                pilotsView.Add(model);
            }
            return pilotsView;
        }

        public List<CarViewModel> GetPilotCars(int id)
        {
            List<CarViewModel> carsView = new List<CarViewModel>();
            foreach(var item in _pilotRepository.GetPilotCars(id))
            {
                CarViewModel model = new CarViewModel();
                model.Car_ID = item.Car_ID;
                model.Pilot_ID = item.Pilot_ID;
                model.Name = item.Name;
                model.Engine = item.EngineType;
                model.Power = item.Power;
                model.FuelType = item.FuelType;
                model.Weight = item.Weight;
                carsView.Add(model);
            }
            return carsView;
        }

        public List<AchievementViewModel> GetPilotAchievements(int id)
        {
            List<AchievementViewModel> achievementView = new List<AchievementViewModel>();
            foreach(var item in _pilotRepository.GetPilotAchievements(id))
            {
                AchievementViewModel model = new AchievementViewModel();
                model.Achievement_ID = item.Achievement_ID;
                model.Pilot_ID = item.Pilot_ID;
                model.Name = item.Name;
                model.Place = item.Place;
                model.Car = item.Car;
                model.Year = item.Year;
                model.Prize = item.Prize;
                achievementView.Add(model);
            }
            return achievementView;
        }

        public Pilot GetById(uint id)
        {
            return _pilotRepository.GetById(id);
        }
    }
}
