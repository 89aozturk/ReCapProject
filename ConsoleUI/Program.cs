using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            //var result = carManager.GetCarDetails();
            //if (result.Success==true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.BrandName + "/" + car.ColorName); ;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            //foreach (var car in carManager.GetCarDetails())
            //{
            //   Console.WriteLine(car.CarId + " " + car.DailyPrice);
            //}

            //carManager.Add(new Car { BrandId = 12, ColorId = 4, ModelYear = 2016, DailyPrice = 165, Description = "R" });
            //carManager.Delete(new Car { CarId = 2002 });


            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Update(new Brand { BrandId = 12,BrandName="Audi" });

            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { ColorName = "Altın Sarsı" });

            //UserManager userManager = new UserManager(new EfUserDal());
            //userManager.Add(new User { Email = "ali.oz@hot", FirstName = "Ali", LastName = "Oz", Password = "354798" });

            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //customerManager.Add(new Customer { UserId = 4, CompanyName = "DCompany" });
            //customerManager.Update(new Customer { UserId=3,CompanyName = "BCompany" });

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental
            {
                CarId = 5,
                CustomerId = 3,
                RentDate = DateTime.Now.AddDays(-2),
                ReturnDate=DateTime.Now
              
            });
            Console.WriteLine(result.Message);

        }


    }
}
