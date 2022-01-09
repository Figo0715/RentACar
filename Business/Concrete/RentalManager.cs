using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public IResult Add(Rental rental)
        {
            
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IDataResult<bool> CheckIfAnyRentalBetweenSelectedDates(int carId, DateTime rentDate, DateTime returnDate)
        {
            throw new NotImplementedException();
        }

        public IDataResult<bool> CheckIfCanCarBeRentedNow(int carId)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int rentalId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>> (_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }

        public IDataResult<Rental> GetRentalById(int rentalId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<RentalDetailDto>> GetRentalsByCustomerIdWithDetails(int customerId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<RentalDetailDto>> GetRentalsDetails()
        {
            throw new NotImplementedException();
        }

        public IDataResult<int> Rent(RentPaymentRequestModel rentPaymentRequest)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Rental rental)
        {
            throw new NotImplementedException();
        }
    }
}
