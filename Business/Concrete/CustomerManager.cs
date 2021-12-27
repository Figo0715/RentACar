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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            if (customer.CompanyName.Length < 2)
            {
                return new ErrorResult(Messages.CustomerCompanyNameInvalid);
            }
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer GetById(int id)
        {
            return _customerDal.Get(cu => cu.Id == id);
        }
    }
}
