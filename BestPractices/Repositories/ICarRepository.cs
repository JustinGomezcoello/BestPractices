using System;
using System.Collections.Generic;
using BestPracticesWorkshop.Domain;

namespace BestPracticesWorkshop.Repositories
{
    public interface ICarRepository
    {
        List<Car> GetAll();
        Car GetById(Guid id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Guid id);
    }
}
