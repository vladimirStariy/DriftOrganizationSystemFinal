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
    public class CarService
    {
        CarRepository _carRepository = new CarRepository();

        public void Create(CarViewModel model)
        {
            var car = new Car()
            {
                Name = model.Name,
                EngineType = model.Engine,
                Power = model.Power,
                FuelType = model.FuelType,
                Weight = model.Weight,
                Pilot_ID = model.Pilot_ID
            };
            _carRepository.AddCar(car);
        }
        public void Edit(CarViewModel model)
        {
            var car = new Car()
            {
                Car_ID = model.Car_ID,
                Name = model.Name,
                EngineType = model.Engine,
                Power = model.Power,
                FuelType = model.FuelType,
                Weight = model.Weight,
                Pilot_ID = model.Pilot_ID
            };
            _carRepository.EditCar(car);
        }
        public void Delete(int id)
        {
            _carRepository.DeleteCar(id);
        }
        public Car GetById(uint id)
        {
            return _carRepository.GetById(id);
        }
    }
}
