using System;
using System.Collections.Generic;
using System.Linq;
using BestPracticesWorkshop.Domain;

namespace BestPracticesWorkshop.Repositories
{
    public class InMemoryCarRepository : ICarRepository
    {
        private readonly List<Car> _cars = new();

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(Guid id)
        {
            return _cars.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Car car)
        {
            car.Id = Guid.NewGuid();
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            var index = _cars.FindIndex(c => c.Id == car.Id);
            if (index >= 0)
            {
                _cars[index] = car;
            }
        }

        public void Delete(Guid id)
        {
            var car = GetById(id);
            if (car != null)
            {
                _cars.Remove(car);
            }
        }
    }
}
