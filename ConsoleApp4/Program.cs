using System;
using System.Collections.Generic;
using FuelStorageCs;

namespace ConsoleApp4
{
    class Machine
    {
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
                return ERROR_ID.Engine;

            if (!f.Status)
                return ERROR_ID.Fuel;

            if (!w.Status)
                return ERROR_ID.Wheels;

            return ERROR_ID.None;
        }
    }






}
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

