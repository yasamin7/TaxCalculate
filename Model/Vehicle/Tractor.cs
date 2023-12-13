using congestion.calculator.Contract;
using System;

namespace congestion.calculator.Model.Vehicle
{
    public  class Tractor : IVehicle
    {
        public string Type => "Tractor";

        public bool TollFree => Enum.IsDefined(typeof(TollFreeVehicles), this.Type);
    }
}
