using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                CarManager carManager = new CarManager(new EfCarDal());

                Console.WriteLine("Id     Model      Günlük Ücreti     Açıklama");
                Console.WriteLine("__________________________________________________");
                foreach (var car in carManager.GetAll())
                {
                    Console.WriteLine(car.CarId + "      " + car.ModelYear + "           " + car.DailyPrice + "         " + car.Description);
                }

                Console.WriteLine("\n\nBrandId'si 1 Olan Araçların Listelenmesi");
                Console.WriteLine("__________________________________________________");
                foreach (var car in carManager.GetCarsByBrandId(1))
                {
                    Console.WriteLine(car.Description);
                }

                Console.WriteLine("\n\nColorId'si 2 Olan Araçların Listelenmesi");
                Console.WriteLine("__________________________________________________");
                foreach (var car in carManager.GetCarsByColorId(2))
                {
                    Console.WriteLine(car.Description);
                }
                Console.WriteLine("\n\nYeni Araç Ekleme Ve Tüm Listenin Tekrar Listelenmesi");
                Console.WriteLine("__________________________________________________");
                carManager.Add(new Car { CarId = 7, BrandId = 4, ColorId = 1, DailyPrice = 500, Description = "Tesla Model 3", ModelYear = "2015" });
                foreach (var car in carManager.GetAll())
                {
                    Console.WriteLine(car.CarId + "      " + car.ModelYear + "           " + car.DailyPrice + "         " + car.Description);
                }


            }
        }
    }
}
