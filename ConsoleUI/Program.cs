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
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(12))
            {
                Console.WriteLine(car.Id + " " + car.BrandId);
            }

            //carManager.Add(new Car { BrandId = 12, ColorId = 4, ModelYear = 2016, DailyPrice = 165, Description = "R" });

            //Brand brand = new Brand { BrandId = 12, BrandName = "Audi" };



        }


    }
}
