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
    public class CustomerCreditCardManager : ICustomerCreditCardService
    {
        ICustomerCreditCardDal _customerCreditCardDal;

        public CustomerCreditCardManager(ICustomerCreditCardDal customerCreditCardDal)
        {
            _customerCreditCardDal = customerCreditCardDal;
        }

        public IResult Add(CustomerCreditCard customerCreditCard)
        {
          
            _customerCreditCardDal.Add(customerCreditCard);
            return new SuccessResult(Messages.CustomerCreditCardAdded);
        }

        public IDataResult<List<CustomerCreditCard>> GetAll()
        {
            return new SuccessDataResult<List<CustomerCreditCard>>(_customerCreditCardDal.GetAll());
        }

        public IDataResult<CustomerCreditCard> GetById(int id)
        {
            return new SuccessDataResult<CustomerCreditCard> (_customerCreditCardDal.Get(ccc=> ccc.Id == id));
        }
    }
}
