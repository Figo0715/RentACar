using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : ICarImageDal
    {
        public void Add(CarImage entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CarImage entity)
        {
            throw new NotImplementedException();
        }

        public CarImage Get(Expression<Func<CarImage, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarImage> GetAll(Expression<Func<CarImage, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(CarImage entity)
        {
            throw new NotImplementedException();
        }
    }
}
