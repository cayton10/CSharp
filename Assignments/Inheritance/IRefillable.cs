using System;
namespace Inheritance
{
    public interface IRefillable
    {
        //Required property
        float FuelPercentage { get; }
        //Required method
        void Refill(int amt);
    }
}
