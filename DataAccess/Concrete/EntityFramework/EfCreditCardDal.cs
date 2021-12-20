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
    public class EfCreditCardDal : ICreditCardDal
    {
        public void Add(CreditCard entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CreditCard entity)
        {
            throw new NotImplementedException();
        }

        public CreditCard Get(Expression<Func<CreditCard, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CreditCard> GetAll(Expression<Func<CreditCard, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(CreditCard entity)
        {
            throw new NotImplementedException();
        }
    }
}
