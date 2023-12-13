namespace congestion.calculator.Contract
{
    public interface IVehicle
    {
        string Type { get; }
        bool TollFree { get; }
    }
}