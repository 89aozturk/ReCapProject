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
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(car.CarId + " " + car.DailyPrice);
            //}

            //carManager.Add(new Car { BrandId = 12, ColorId = 4, ModelYear = 2016, DailyPrice = 165, Description = "R" });

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Update(new Brand { BrandId = 12,BrandName="Audi" });

            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Altın Sarsı" });


        }


    }
}
