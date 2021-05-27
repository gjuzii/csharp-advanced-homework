﻿using System;
using System.Collections.Generic;
using System.Text;

namespace homework03.Classes
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public int BatchNumber { get; set; }
        public Vehicle(int id, string type, int year, int batchNumber)
        {
            Id = id;
            Type = type;
            YearOfProduction = year;
            BatchNumber = batchNumber;
        }

        public virtual void PrintVehicle()
        {
            Console.WriteLine($"id - {Id}, type -{Type} year of production - {YearOfProduction}");
        }
    }
}
