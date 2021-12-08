using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {

        }

        public string IsTrunkOrHatchback { get; set; } = "Trunk";
        public string IsCoupeOrSedan { get; set; }

        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfSeats { get; set; }
        public double GasMileage { get; set; }
        public string Logo { get; set; }
        public string CountryOfOrigin { get; set; }
        public int BedLength { get; set; }
        public string TwoOrFourWheelDrive { get; set; }
    }
}
