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
            //if (creditCard.CardHolderFullName.Length < 2)
            //{
            //    return new ErrorResult(Messages.CreditCardHolderFullNameInvalid);
            //}
            _creditCardDal.Add(creditCard);
            return new SuccessResult(Messages.CustomerCreditCardSaved);
        }

        public IDataResult<CreditCard> Get(string cardNumber, string expireYear, string expireMonth, string cvc, string cardHolderFullName)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CreditCard>> GetAll()
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll());
        }

        public IDataResult<CreditCard> GetById(int id)
        {
            return new SuccessDataResult<CreditCard>(_creditCardDal.Get(cc => cc.Id == id));
        }

        public IResult Update(CreditCard creditCard)
        {
            throw new NotImplementedException();
        }

        public IResult Validate(CreditCard creditCard)
        {
            throw new NotImplementedException();
        }
    }
}
