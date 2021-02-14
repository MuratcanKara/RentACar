using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        Car GetById(int id);
        void Add(Car car);


    }
}
