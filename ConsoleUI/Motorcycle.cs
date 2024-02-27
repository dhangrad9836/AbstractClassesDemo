using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        //properties
        public bool HasSideCart { get; set; }

        //Abstract methods
        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is zooming");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("The Motorcycle is Driving in virtual method being overrided.");
        }


    }
}
