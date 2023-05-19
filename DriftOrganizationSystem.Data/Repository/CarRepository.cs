using DriftOrganizationSystem.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriftOrganizationSystem.Data.Repository
{
    public class CarRepository
    {
        public void AddCar(Car entity)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                _db.Cars.Add(entity);
                _db.SaveChanges();
            }
        }

        public void EditCar(Car entity)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                _db.Cars.Update(entity);
                _db.SaveChanges();
            }
        }

        public void DeleteCar(int id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                var car = _db.Cars.Where(x => x.Car_ID == id).FirstOrDefault();
                _db.Cars.Remove(car);
                _db.SaveChanges();
            }
        }

        public Car GetById(uint id)
        {
            using (DriftDbContext _db = new DriftDbContext())
            {
                return _db.Cars.Where(x => x.Car_ID == id).FirstOrDefault();
            }
        }
    }
}
