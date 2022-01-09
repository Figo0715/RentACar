using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            //if (customer.CompanyName.Length < 2)
            //{
            //    return new ErrorResult(Messages.CustomerCompanyNameInvalid);
            //}
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(int customerId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(cu => cu.Id == id));
        }

        public IDataResult<Customer> GetCustomerById(int customerId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Customer> GetCustomerByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomersDetails()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Customer customer)
        {
            throw new NotImplementedException();
        }

        IDataResult<int> ICustomerService.Add(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
