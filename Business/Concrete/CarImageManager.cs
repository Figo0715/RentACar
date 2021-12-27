using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(CarImage carImage)
        {

            if (carImage.ImagePath.Length < 2)
            {
                return new ErrorResult(Messages.CarImagePathInvalid);
            }
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageAdded);
        }

        public List<CarImage> GetAll()
        {
            return _carImageDal.GetAll();
        }

        public CarImage GetById(int id)
        {
            return _carImageDal.Get(ci => ci.Id == id);
        }
    }
}
