using BestPracticesWorkshop.Domain;
using BestPracticesWorkshop.Factories;
using BestPracticesWorkshop.Repositories;
using BestPracticesWorkshop.Builders;

namespace BestPracticesWorkshop.Services
{
    public class AddVehicleService
    {
        private readonly VehicleFactory _factory;
        private readonly ICarRepository _repository;

        public AddVehicleService(
            VehicleFactory factory,
            ICarRepository repository)
        {
            _factory = factory;
            _repository = repository;
        }

        public Car Add(string modelName)
        {
            // Crear vehículo usando Factory
            var baseCar = _factory.Create(modelName);

            // Aplicar defaults usando Builder
            var car = new VehicleBuilder()
                .WithBrand(baseCar.Brand)
                .WithModel(baseCar.Model)
                .WithColor(baseCar.Color)
                .WithDefaults()
                .Build();

            // Guardar usando Repository
            _repository.Add(car);

            return car;
        }
    }
}
