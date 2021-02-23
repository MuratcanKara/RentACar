using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, SunshineContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail()
        {
            using (SunshineContext context = new SunshineContext())
            {
                var result = from re in context.Rentals
                    join cu in context.Customers on re.CustomerId equals cu.UserId
                    join c in context.Cars on re.CarId equals c.CarId
                    select new RentalDetailDto()
                    {
                        RentalId =  re.RentalId,
                        Description = c.Description, 
                        CompanyName = cu.CompanyName,
                        RentDate = re.RentDate,
                        ReturnDate = re.ReturnDate


                    };

                return result.ToList();
            }

        }

    }
}
