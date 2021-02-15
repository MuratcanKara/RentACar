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
    public class EfCarDal : EfEntityRepositoryBase<Car, SunshineContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (SunshineContext context = new SunshineContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join d in context.Colors on c.ColorId equals d.Id


                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear,
                                 BrandName = b.BrandName,
                                 ColorName = d.ColorName
                             };

                return result.ToList();
            }



            //toDo1
        }
    }
}
