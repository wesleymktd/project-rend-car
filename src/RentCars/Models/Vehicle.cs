using RentCars.Types;
namespace RentCars.Models;

//3 - Crie a classe `Vehicle`
public class Vehicle
{
    string Brand {get; set;} = "";
    string Model {get; set;} = "";
    decimal Price {get; set;}
    FuelType fuel {get; set;}
    int EngineCapacity {get; set;}
    Color MainColor {get; set;}
    int Year {get; set;}
    double PricePerDay {get; set;}
    bool IsRented {get; set;} = false;
}