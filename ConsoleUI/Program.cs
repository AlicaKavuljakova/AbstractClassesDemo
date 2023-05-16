using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles= new List<Vehicle>();
            var myCar = new Car()
            {
                HasTrunk = true,
                Make = "Smart",
                Model = "Fortwo",
                Year = 2013
            };
            vehicles.Add(myCar);
            var myMotorcycle= new Motorcycle();
            myMotorcycle.HasSideCart = true;
            myMotorcycle.Make = "Harley";
            myMotorcycle.Year = 2023;
            myMotorcycle.Model = "Something Something";
            vehicles.Add(myMotorcycle);

            Vehicle davesCar = new Car();
            vehicles.Add(davesCar);

            Vehicle daveMotorcycle= new Motorcycle();
            
            vehicles.Add(daveMotorcycle);


            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
           foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"make:{vehicle.Make}, Model:{vehicle.Model}, Year:{vehicle.Year}");
              vehicle.DriveAbstract();
                vehicle.Printinfo();
            }
            
           
          

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
