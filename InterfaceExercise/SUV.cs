using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{

    public class SUV : IVehicle, ICompany
    {

        public int CubicFeetOfCargoSpace { get; set; }
        public int NumberOfSeatRows { get; set; }

        public string Logo { get; set; }
        public string CountryOfOrigin { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfSeats { get; set; }
        public double GasMileage { get; set; }
        public int BedLength { get; set; }
        public string TwoOrFourWheelDrive { get; set; }
    }













}