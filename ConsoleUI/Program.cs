using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.Name);
            }

            //Car car = new Car()
            //{
            //    BrandId = 1,
            //    ColorId = 2,
            //    Name = "Bentley",
            //    DailyPrice = 15000,
            //    Description = "Bentley",
            //    ModelYear = 2022
            //};

            //CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(car);

            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //Color color = new Color()
            //{
            //    Id=5
            //};
            //colorManager.Delete(color);

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //Brand brand = new Brand()
            //{
            //    Name = "Volvo"
            //};
            //brandManager.Add(brand);

        }
    }
}
