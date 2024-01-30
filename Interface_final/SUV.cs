using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_final
{
    internal class SUV: IVehicle, ICompany
    {
        public string FourWheelDrive { get; set; }
        public bool HasSeatCapacity { get; set; }
        public int NumberOfWheels { get; set; }
        public string Driver { get; set; }
        public bool HasHonk { get; set; }
        public string GearBox { get; set; }
        public string EngineType { get; set; }
        public bool HasLogo { get; set; }
        public void DisplayDetails()
        {
            Console.WriteLine($"My SUV has four wheel drive {FourWheelDrive}" +
                $",good seat capacity{HasSeatCapacity}, number of wheels {NumberOfWheels}," +
                $"with gearbox{GearBox}, engine type of {EngineType},has logo{HasLogo} " +
                $"and good driver{Driver}");


        }
    }
}
