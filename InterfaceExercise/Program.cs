using System;
using System.Collections.Generic;
using static InterfaceExercise.Interfaces;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Car fusion = new Car()
            {
                HasEngine = true,
                HasSmallTrunk = true,
                CountryofOrigin = "USA",
                Seats4 = "Yes",
                Logo = "Ford",
                HowManyDoors = 4,
                HowManyWheels = 4,
                IsCovertible = false

            };
            Truck Tacoma = new Truck()
            {
                HasEngine = true,
                HasBed = true,
                HasSmallTrunk = false,
                HowManyWheels = 4,
                CountryofOrigin = "Japan",
                ExtendedCab = false,
                HowManyDoors = 2,
                Seats4 = "Too small for 4 seats",
                IsCovertible = false,
                Logo = "Toyota Symbol"
            };

            SUV suburban = new SUV()
            {
                Has3RowsofSeats = true,
                HasBadGasMileage = true,
                HasEngine = true,
                HasSmallTrunk = false,
                HowManyDoors = 4,
                HowManyWheels = 4,
                CountryofOrigin = "USA",
                IsCovertible = false,
                Seats4 = "Yes",
                Logo = "GMC"

            };

            List<ICompany> typesOfCars = new List<ICompany>();

            typesOfCars.Add(suburban);
            typesOfCars.Add(Tacoma);
            typesOfCars.Add(fusion);

            foreach (var item in typesOfCars)
            {
                Console.WriteLine($"This vehicles logos: {item.Logo} \nThe country that makes this vehicle is: {item.CountryofOrigin}");
                Console.WriteLine();
            }

             
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany- DONE

            //Create 3 classes called Car , Truck , & SUV - DONE

            //In your IVehicle - DONE
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany - DONE
            
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
