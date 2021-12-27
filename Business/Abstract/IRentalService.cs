using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IRentalService
    {
        List<Rental> GetAll();
        Rental GetById(int id);
        IResult Add(Rental rental);
    }
}
