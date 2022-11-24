using DataAccess.Abtract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal() 
        {
            _car = new List<Car> 
            { 
                new Car {Id=7,BrandId=3,ColorId=2,DailyPrice=200,Description="Renault Clio",ModelYear="2015" },
                new Car {Id=5,BrandId=2,ColorId=2,DailyPrice=155,Description="fiat egea",ModelYear="2010" } 
            };
        
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarDelete=_car.SingleOrDefault(x => x.Id==car.Id);
            _car.Remove(CarDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car CarUpdate=_car.SingleOrDefault(x => x.Id==car.Id);
            CarUpdate.DailyPrice=car.DailyPrice;
            CarUpdate.Description=car.Description;


        }
    }
}
