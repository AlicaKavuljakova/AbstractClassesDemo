﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public  int Year { get; set; } = 0000;
        public string Make { get; set; } = "default";
        public string Model { get; set; } = "default";
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Vehicle can drive on land-Default scope");
        }
        public abstract void Printinfo();
    }
}
/*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */