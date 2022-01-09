using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using Core.Utilities.Bussiness;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IBrandService _brandService;
        public CarManager(ICarDal carDal,IBrandService brandService)
        {
            _carDal = carDal;
            _brandService = brandService;
        }

        //Claim

        //[SecuredOpertion("admin,car.add")]
        [ValidationAspect(typeof(CarValidator))]
        public IDataResult<int> Add(Car car)
        {
            //İş kuralı kullanımı
            /* IResult result= BussinessRules.Run(CheckIfCarCountOfBrand(car.BrandId),(CheckIfCarNameExists(car.ModelName),CheckIfCategoryLimitExceded()));*/
            //if (result!=null)
            //{
            //    return result;
            //}

            _carDal.Add(car);
            var result = _carDal.Get(c =>
                c.ModelName == car.ModelName &&
                c.Description == car.Description &&
                c.BrandId == car.BrandId &&
                c.ColorId == car.ColorId &&
                c.DailyPrice == car.DailyPrice &&
                c.ModelYear == car.ModelYear);
            if (result != null)
            {
                return new SuccessDataResult<int>(result.Id, Messages.CarAdded);
            }
            return new ErrorDataResult<int>(-1, "Araç eklenirken bir sorun oldu");
        }

        public IResult Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAll()
        {
            //if (DateTime.Now.Hour == 22)
            //{
            //    return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            //}
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetAllByBranId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            //if (DateTime.Now.Hour == 02)
            //{
            //    return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            //}
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<CarDetailDto> GetCarDetails(int carId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailDto>> GetCarsByBrandIdWithDetails(int brandId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailDto>> GetCarsByColorIdWithDetails(int colorId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailDto>> GetCarsByFilterWithDetails(int brandId, int colorId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailDto>> GetCarsWithDetails()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Car car)
        {
            throw new NotImplementedException();
        }

        ////İş kuralı (Model sayısı 15 e eşit veya büyükse bu modele araç kaydı yapma)
        //private IResult CheckIfCarCountOfBrand(int brandId)
        //{
        //    var result = _carDal.GetAll(c => c.BrandId == brandId).Count();
        //    if (result >= 15)
        //    {
        //        return new ErrorResult(Messages.CarCountOfBrandError);
        //    }
        //    return new SuccessResult();
        //}

        ////İş kuralı (Aynı isimde araç kaydı yapma)
        //private IResult CheckIfCarNameExists(string carName)
        //{
        //    var result = _carDal.GetAll(c => c.ModelName == carName).Any();
        //    if (result)
        //    {
        //        return new ErrorResult(Messages.CarNameAlreadyExists);
        //    }
        //    return new SuccessResult();
        //}

        //Eğer mevcut brand sayısı 15 i geçtiyse sisteme yeni araç eklenemez.
        //private IResult CheckIfCategoryLimitExceded()
        //{
        //    var result = _brandService.GetAll();
        //    if (result.Data.Count>15)
        //    {
        //        return new ErrorResult(Messages.CheckIfCategoryLimitExceded);
        //    }
        //    return new SuccessResult();
        //}

    }
}
