using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine(  "This motorcycle can drive very fast.");
        }
        public bool HasSideCart { get; set; }
      
        public override void DriveVirtual()
        {
            Console.WriteLine("Drives like a dragon overriding virtual method ");
        }

        public override void Printinfo()
        {
            Console.WriteLine($"has side cart: {HasSideCart}");
        }
    }
}
