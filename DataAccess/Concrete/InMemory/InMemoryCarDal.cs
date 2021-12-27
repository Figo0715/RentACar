using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _carList;
        public InMemoryCarDal()
        {
            _carList = new List<Car> {
                new Car{BrandId = 1, ColorId = 3, ModelName = "X5 xDrive45E", ModelYear = 2010, DailyPrice = 500, Description = "1.2 liter engine"},
                new Car{BrandId = 6, ColorId = 2, ModelName = "S60", ModelYear = 2015, DailyPrice = 750, Description = "1.4 liter engine"},
                new Car{BrandId = 2, ColorId = 7, ModelName = "Benz E300", ModelYear = 2012, DailyPrice = 900, Description = "1.4 liter engine"},
                new Car{ BrandId = 3, ColorId = 4, ModelName = "T-Roc", ModelYear = 2021, DailyPrice = 1500, Description = "1.6 liter engine"},
                new Car{BrandId = 5, ColorId = 4, ModelName = "500L", ModelYear = 2017, DailyPrice = 600, Description = "1.6 liter engine" }
            };
        }
        public void Add(Car car)
        {
            _carList.Add(car);
        }

        public void Delete(Car car)
        {
            _carList.Remove (_carList.SingleOrDefault(c => c.Id == car.Id));
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carList;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _carList.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _carList.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
