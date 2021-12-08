using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {

        }

        public int BedLength { get; set; }
        public string TwoOrFourWheelDrive { get; set; } = "2WD";
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfSeats { get; set; }
        public double GasMileage { get; set; }
        public string Logo { get; set; }
        public string CountryOfOrigin { get; set; }
    }
}
