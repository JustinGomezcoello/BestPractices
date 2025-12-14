using BestPracticesWorkshop.Domain;

namespace BestPracticesWorkshop.Factories
{
    public abstract class VehicleFactory
    {
        public abstract Car Create(string modelName);
    }
}
