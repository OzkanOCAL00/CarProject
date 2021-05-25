using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 1000, ModelYear = 2021, Description = "Mercedes"},
                new Car { Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 500, ModelYear = 2018, Description = "Volvo" },
                new Car { Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 1500, ModelYear = 2005, Description = "BMV" },
                new Car { Id = 4, BrandId = 2, ColorId = 3, DailyPrice = 700, ModelYear = 2007, Description = "Toyota" },
                new Car { Id = 5, BrandId = 1, ColorId = 4, DailyPrice = 800, ModelYear = 2012, Description = "Fiat" },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //Linq
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;


        }
    }
}
