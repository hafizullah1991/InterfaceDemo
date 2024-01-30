using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_final
{
    internal class Truck:IVehicle, ICompany
    {
        public int CargoCapacity { get; set; }
        public bool HasTrail { get; set; }
        // vehicle
        public int NumberOfWheels { get; set; }
        public string Driver { get; set; }
        public bool HasHonk { get; set; }
        public string GearBox { get; set; }
        //compnay
        public string EngineType { get; set; }
        public bool HasLogo { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"My Truck has capacity{CargoCapacity}" +
                $",has trail{HasTrail},number of wheels {NumberOfWheels}" +
                $",Gearbox {GearBox},engine type is {EngineType},has logo{HasLogo} scary honk {HasHonk}");
        }
    }
}
