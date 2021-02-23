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
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //cargetall();
            //cardetails();
            //userManager.Add(new User { Id = 3, FirstName = "Can", LastName = "Yüksel", Email = "Deneme@deneme.com", Password = "123456" });
            //customerManager.Add(new Customer { UserId=2 , CompanyName = "Deneme" });
            rentalManager.Add(new Rental { RentalId = 2, CarId = 1, CustomerId = 1, RentDate = new DateTime(2021, 02, 10) });
            

        }

        private static void cardetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName);
                    Console.WriteLine(car.Description);
                    Console.WriteLine(car.ColorName);
                    Console.WriteLine(car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        //private static void cargetall()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.Description);
        //        Console.WriteLine(car.ModelYear);
        //        Console.WriteLine(car.DailyPrice);
        //        Console.WriteLine("*****************");
        //    }
        //}




    }
}
