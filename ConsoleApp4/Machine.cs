using System;
using System.Collections.Generic;
using System.Text;
using FuelStorageCs;

namespace ConsoleApp4
{
    class Machine
    {
        public Engine engine { get; set; }
        public FuelStorage fuelstorage { get; set; }
        public Wheels wheels { get; set; }
        public Creation creation { get; set; }
        public Machine(Engine e, FuelStorage f, Wheels w, Creation c)
        {
            engine = e;
            fuelstorage = f;
            wheels = w;
            creation = c;
        }
        public enum ERROR_ID
        {
            None,
            Engine,
            Wheels,
            Fuel
        }
        public ERROR_ID starting(Engine e, FuelStorage f, Wheels w)
        {
            if (!e.Status)
            {
                Console.WriteLine("No! Engine");
                return ERROR_ID.Engine;
            }

            if (!f.Status)
            {
                Console.WriteLine("No! Fuel");
                return ERROR_ID.Fuel;
            }

            if (!w.Status)
            {
                Console.WriteLine("No! Wheels");
                return ERROR_ID.Wheels;
            }
            Console.WriteLine("Working!");
            return ERROR_ID.None;
        }
    }
}
