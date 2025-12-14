using System;
using BestPracticesWorkshop.Domain;

namespace BestPracticesWorkshop.Builders
{
    public class VehicleBuilder
    {
        private readonly Car _car = new();

        public VehicleBuilder WithBrand(string brand)
        {
            _car.Brand = brand;
            return this;
        }

        public VehicleBuilder WithModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public VehicleBuilder WithColor(string color)
        {
            _car.Color = color;
            return this;
        }

        public VehicleBuilder WithDefaults()
        {
            _car.Year = DateTime.Now.Year;
            _car.IsActive = true;
            _car.IsDefaultConfig = true;
            return this;
        }

        public Car Build()
        {
            _car.Id = Guid.NewGuid();
            return _car;
        }
    }
}
