using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_final
{
    internal interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public string Driver { get; set; }
        public bool HasHonk { get; set; }
        public string GearBox { get; set; }

        public void DisplayDetails();
    }
}
