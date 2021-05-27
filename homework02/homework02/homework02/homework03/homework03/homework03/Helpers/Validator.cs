using homework03.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace homework03.Helpers
{
    class Validator
    {
        public static void Validate(Vehicle vehicle)
        {
            if (vehicle.Id != 0 && vehicle.Type != " " && vehicle.YearOfProduction != 0 )
            {
                Console.WriteLine("The validation was successful");
            }
            else
            {
                Console.WriteLine("The validation was not successful ");
            }
        }
    }
}
