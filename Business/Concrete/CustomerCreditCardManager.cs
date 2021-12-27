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

        public List<CustomerCreditCard> GetAll()
        {
            return _customerCreditCardDal.GetAll();
        }

        public CustomerCreditCard GetById(int id)
        {
            return _customerCreditCardDal.Get(ccc=> ccc.Id == id);
        }
    }
}
