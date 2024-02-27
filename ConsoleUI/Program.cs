using System;
using System.Collections.Generic;
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
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) 
             * but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion

            //create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();

            //create 4 instances
            Car car_vehicle = new Car()
            {
                HasTrunk = true,
                Make = "Toyota",
                Model = "4Runner",
                Year = "2024"
            };

            Motorcycle motorcycle_vehicle = new Motorcycle()
            {
                HasSideCart = true,
                Make = "Kawaski",
                Model = "XCV234",
                Year = "2022"
            };


            //create the other two of type Vehicle of EXPLICIT type (Vehicle) you need to use the actual name
            //of the type-----VEHICLE
            Vehicle car_vehicle_Explicit = new Car()
            {
                Make = "Honda",
                Model = "Civic",
                Year = "2020"
            };
            Vehicle motorcycle_vehicle_Explicit = new Motorcycle()
            {
                Make = "Honda",
                Model = "CF123",
                Year = "2022"
            };

            //add the vehicles to the list
            vehicles.Add(car_vehicle);
            vehicles.Add(motorcycle_vehicle);
            vehicles.Add(car_vehicle_Explicit);
            vehicles.Add(motorcycle_vehicle_Explicit);

            //use a for loop to loop throught the vehicles
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Make}");
                Console.WriteLine($"{vehicle.Model}");
                Console.WriteLine($"{vehicle.Year}");
                Console.WriteLine("----------------");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine("----------------");
            }


            Console.ReadLine();
        }
    }
}
