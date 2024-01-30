using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_final
{
    internal class Car: IVehicle, ICompany
    {
        // car
        public int NumberOFDoors { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        public string Driver { get; set; }
        public bool HasHonk { get; set; }
        public string GearBox { get; set; }
        //Vehicle
        //Company
        public string EngineType { get; set; }
        public bool HasLogo { get; set; }

        //Stubbed out method
        public void DisplayDetails()
        {
            Console.WriteLine($"This car has{NumberOfWheels}" +
                $" number of wheels Model{Model}, has {NumberOFDoors} number of doors, gear box{GearBox}" +
                $"Engine type {EngineType} ,company logo{HasLogo}");
        }
    }
}
