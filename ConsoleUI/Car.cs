using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("This car drives very smooth.");
        }

        public override void Printinfo()
        {
            Console.WriteLine($"has trunk: {HasTrunk}");
        }

        public bool HasTrunk { get; set; }
           
    } 
}
