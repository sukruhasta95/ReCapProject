using DataAccess.Abstract;
using Entities.Concrete;
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
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1,Name= "BMW",ColorId=2,BrandId=2,DailyPrice=100000,Description="testCar",ModelYear=2022},
                new Car {Id=2,Name="merso",ColorId=1,BrandId=1,DailyPrice=150000,Description="testCar2",ModelYear=2021}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }


        public void Delete(Car car)
        {
            Car cars = _cars.FirstOrDefault(x => x.Id == car.Id);
            _cars.Remove(car);
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

        public List<Car> GetById(int Id)
        {
           return _cars.Where(x => x.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car cars = _cars.FirstOrDefault(x => x.Id == car.Id);
            cars.DailyPrice=car.DailyPrice;
            cars.Description=car.Description;
        }

      
    }
}
