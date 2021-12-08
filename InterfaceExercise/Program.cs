using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> objectList = new List<IVehicle>();

            IVehicle car1 = new Car()
            {
                CountryOfOrigin = "USA",
                Logo = "Silver Shield",
                GasMileage = 34,
                IsCoupeOrSedan = "Coupe",
                IsTrunkOrHatchback = "Trunk",
                NumberOfDoors = 2,
                NumberOfSeats = 2,
                NumberOfWheels = 4
            };

            IVehicle truck1 = new Truck()
            {
                CountryOfOrigin = "Japan",
                Logo = "Two Horses",
                NumberOfDoors = 4,
                NumberOfWheels = 4,
                NumberOfSeats = 2,
                BedLength = 12,
                TwoOrFourWheelDrive = "2WD",
                GasMileage = 14

            };

            IVehicle suv1 = new SUV()
            {
                CountryOfOrigin = "France",
                CubicFeetOfCargoSpace = 41,
                GasMileage = 15,
                NumberOfDoors = 4,
                Logo = "Block of Cheese",
                NumberOfSeatRows = 3,
                NumberOfSeats = 8,
                NumberOfWheels = 4
            };

            objectList.Add(car1);
            objectList.Add(truck1);
            objectList.Add(suv1);

            foreach (var item in objectList)
            {
                Console.WriteLine($"Vehicle List with attributes: \n" +
                    $"{item.CubicFeetOfCargoSpace}.\n" +
                    $"{item.NumberOfWheels}\n" +
                    $"{item.NumberOfDoors}\n" +
                    $"{item.IsCoupeOrSedan}");
            }












            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
