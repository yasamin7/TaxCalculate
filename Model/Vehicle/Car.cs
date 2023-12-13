using congestion.calculator.Contract;

namespace congestion.calculator.Model.Vehicle
{
    public abstract class Car : IVehicle
    {
        public abstract string Type { get; }

        public abstract bool TollFree { get; }
    }
}