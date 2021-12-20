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
    public class EfCustomerCreditCardDal : ICustomerCreditCardDal
    {
        public void Add(CustomerCreditCard entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CustomerCreditCard entity)
        {
            throw new NotImplementedException();
        }

        public CustomerCreditCard Get(Expression<Func<CustomerCreditCard, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CustomerCreditCard> GetAll(Expression<Func<CustomerCreditCard, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerCreditCard entity)
        {
            throw new NotImplementedException();
        }
    }
}
