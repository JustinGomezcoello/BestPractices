using System;

namespace BestPracticesWorkshop.Domain
{
    public class Car
    {
        public Guid Id { get; set; }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public int Year { get; set; }

        // Propiedades por defecto actuales
        public bool IsActive { get; set; }
        public bool IsDefaultConfig { get; set; }

        // Aquí se agregarán las 20 propiedades del siguiente sprint
        // public string PropertyX { get; set; }
    }
}
