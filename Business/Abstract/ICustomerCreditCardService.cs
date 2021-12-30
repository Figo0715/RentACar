using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerCreditCardService
    {
        IDataResult<List<CustomerCreditCard>> GetAll();
        IDataResult<CustomerCreditCard> GetById(int id);
        IResult Add(CustomerCreditCard customerCreditCard);
    }
}
