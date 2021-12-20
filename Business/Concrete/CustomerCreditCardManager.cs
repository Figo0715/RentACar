using Business.Abstract;
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
        public List<CustomerCreditCard> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
