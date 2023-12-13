using System;

namespace congestion.calculator.Contract
{
    public interface ITaxService
    {
       int GetTax(IVehicle vehicle, DateTime[] dates);

       int GetTollFee(DateTime date, IVehicle vehicle);
    }
}
