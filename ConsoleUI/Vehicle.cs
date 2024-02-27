using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        /*   * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.             * 
             */
        //Properties of vehicle
        public string Year { get; set; } = "2023";
        public string Make { get; set; } = "Lexus";
        public string Model { get; set; } = "XC460";

        //Abstrace method
        public abstract void DriveAbstract();

        //virtual method
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Drivin in virtual without virtual method overrided.");
        }
    }
}
