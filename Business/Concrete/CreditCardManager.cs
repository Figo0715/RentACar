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
    public class CreditCardManager : ICreditCardService
    {
        ICreditCardDal _creditCardDal;

        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }

        public IResult Add(CreditCard creditCard)
        {
            if (creditCard.CardHolderFullName.Length < 2)
            {
                return new ErrorResult(Messages.CreditCardHolderFullNameInvalid);
            }
            _creditCardDal.Add(creditCard);
            return new SuccessResult(Messages.CreditCardAdded);
        }

        public List<CreditCard> GetAll()
        {
            return _creditCardDal.GetAll();
        }

        public CreditCard GetById(int id)
        {
            return _creditCardDal.Get(cc => cc.Id == id);
        }
    }
}
