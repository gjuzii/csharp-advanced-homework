using homework03.Classes;
using homework03.Helpers;
using System;

namespace homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Vehicle vehicle in VehiclesDB.Vehicles)
            {
                vehicle.PrintVehicle();
                Validator.Validate(vehicle);
            }
        }
    }
}
