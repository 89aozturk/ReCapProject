using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _branDal;

        public BrandManager(IBrandDal branDal)
        {
            _branDal = branDal;
        }

        public void Add(Brand brand)
        {
            _branDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _branDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _branDal.GetAll();
        }

        public void Update(Brand brand)
        {
            _branDal.Update(brand);
        }
    }
}
