using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfSeats { get; set; }
        public double GasMileage { get; set; }
        public int BedLength { get; set; }
        public string TwoOrFourWheelDrive { get; set; } = "2WD";
        public int CubicFeetOfCargoSpace { get; set; }
        public int NumberOfSeatRows { get; set; }
        public string IsTrunkOrHatchback { get; set; } = "Trunk";
        public string IsCoupeOrSedan { get; set; }
    }
}
