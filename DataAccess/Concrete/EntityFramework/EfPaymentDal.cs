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
    public class EfPaymentDal : IPaymentDal
    {
        public void Add(Payment entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Payment entity)
        {
            throw new NotImplementedException();
        }

        public Payment Get(Expression<Func<Payment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Payment> GetAll(Expression<Func<Payment, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Payment entity)
        {
            throw new NotImplementedException();
        }
    }
}
