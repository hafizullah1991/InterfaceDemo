namespace Interface_final
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SUV suvCar = new SUV();
            Truck truckCar = new Truck();
            Car myCar = new Car();

            suvCar.HasSeatCapacity = true;
            suvCar.HasLogo = true;
            suvCar.NumberOfWheels = 4;
            suvCar.Driver = "yes";
            suvCar.HasSeatCapacity = true;
            suvCar.EngineType = "Electric";
            suvCar.HasHonk = true;
            suvCar.GearBox = "Auto";


            truckCar.CargoCapacity = 5;
            truckCar.NumberOfWheels = 12;
            truckCar.Driver = "yes";
            truckCar.EngineType = "Gasoline";
            truckCar.HasLogo = true;
            truckCar.HasHonk = true;
            truckCar.GearBox = "manual";


            myCar.HasHonk = true;
            myCar.Driver = "yes";
            myCar.EngineType = "Gasoline";
            myCar.HasLogo = true;
            myCar.GearBox = "yes";
            myCar.NumberOfWheels = 4;
            myCar.GearBox = "Automatic";
            myCar.Model = "Sedan";




            myCar.DisplayDetails();
            truckCar.DisplayDetails();
            suvCar.DisplayDetails();

            
            

           


            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
