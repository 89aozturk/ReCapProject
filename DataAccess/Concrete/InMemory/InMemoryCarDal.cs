using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId=1,BrandId=1, ColorId=1, ModelYear=2012, DailyPrice=80, Description="Rent Fiesta"},
                new Car{CarId=2,BrandId=2, ColorId=3, ModelYear=2018, DailyPrice=150, Description="Rent Focus"},
                new Car{CarId=3,BrandId=2, ColorId=2, ModelYear=2019, DailyPrice=200, Description="Rent Focus"},
                new Car{CarId=4,BrandId=3, ColorId=2, ModelYear=2016, DailyPrice=120, Description="Rent Megane"},
                new Car{CarId=5,BrandId=4, ColorId=1, ModelYear=2020, DailyPrice=250, Description="Rent Citroen"},
                new Car{CarId=6,BrandId=4, ColorId=4, ModelYear=2017, DailyPrice=140, Description="Rent Citroen"},
                new Car{CarId=7,BrandId=3, ColorId=4, ModelYear=2015, DailyPrice=110, Description="Rent Megane"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            Car car = _cars.SingleOrDefault(c => c.CarId == id);
            return car;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
