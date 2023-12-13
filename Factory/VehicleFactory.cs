using congestion.calculator.Contract;
using congestion.calculator.Model.Vehicle;
using System;
using System.Diagnostics;

namespace congestion.calculator.Factory
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            return vehicleType.ToLower() switch
            {
                "ambulance" => new Ambulance(),
                "tractor" => new Tractor(),
                "motorbike" => new Motorbike(),
                _ => throw new ArgumentException("Invalid vehicle type.")
            };
        }
    }
}
