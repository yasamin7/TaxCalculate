using congestion.calculator.Contract;
using System;

namespace congestion.calculator.Model.Vehicle
{
    public  class Motorbike : IVehicle
    {
        public string Type => "Motorbike";

        public bool TollFree => Enum.IsDefined(typeof(TollFreeVehicles),this.Type);
    }
}