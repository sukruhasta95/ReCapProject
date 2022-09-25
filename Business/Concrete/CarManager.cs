using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IBrandDal _brandDal;

        
        public CarManager(ICarDal carDal)
        {
           _carDal = carDal;
           
        }

        public void Add(Car car)
        {
          
            if (car.Name.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine(car.Name + " eklendi.");
            }
            else
            {
                Console.WriteLine("Araç ismi en az 2 karakter olmalıdır ve günlük kiralama bedeli sıfırdan büyük olmalıdır.");
            }

        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetAll(x => x.Id == id).ToList();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(x => x.BrandId == id).ToList();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(x => x.ColorId == id).ToList();

        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
