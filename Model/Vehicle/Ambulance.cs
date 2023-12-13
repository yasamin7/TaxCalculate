using System;

namespace congestion.calculator.Model.Vehicle
{
    public class Ambulance : Car
    {
        public override string Type => "Emergency";

        public override bool TollFree => Enum.IsDefined(typeof(TollFreeVehicles), this.Type);
    }
}
