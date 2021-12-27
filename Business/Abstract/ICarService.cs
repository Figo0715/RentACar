using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBranId(int id);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        List<CarDetailDto> GetCarDetails();
        Car GetById(int id);
        IResult Add(Car car);
    }
}
