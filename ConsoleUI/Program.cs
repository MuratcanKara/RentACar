using System;
using System.Diagnostics.CodeAnalysis;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());





        }
    }
}
