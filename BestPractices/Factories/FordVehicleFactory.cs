using System;
using BestPracticesWorkshop.Domain;

namespace BestPracticesWorkshop.Factories
{
    public class FordVehicleFactory : VehicleFactory
    {
        public override Car Create(string modelName)
        {
            return modelName.ToLower() switch
            {
                "mustang" => new Car
                {
                    Brand = "Ford",
                    Model = "Mustang",
                    Color = "Red"
                },
                "explorer" => new Car
                {
                    Brand = "Ford",
                    Model = "Explorer",
                    Color = "White"
                },
                "escape" => new Car
                {
                    Brand = "Ford",
                    Model = "Escape",
                    Color = "Red"
                },
                _ => throw new ArgumentException("Modelo no reconocido")
            };
        }
    }
}
