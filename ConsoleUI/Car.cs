using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        //Overrided abstract method from abstrace Vehicle class
        public override void DriveAbstract()
        {
            Console.WriteLine("The car is Driving!");
        }

        public bool HasTrunk { get; set; }


    }
}
