using System;
using System.Collections.Generic;
using System.Text;
using FuelStorageCs;

namespace ConsoleApp4
{
    class Engine
    {
        private int power;
        private string mark;
        private int consuming;
        private bool status;

        public Engine(int p, string m, int c, bool s)
        {
            power = p;
            mark = m;
            consuming = c;
            status = s;
        }

        public bool Start()
        {
            return status;
        }

        public bool Start(FuelStorage f)
        {
            if (status == false)
            {
                return status;
            }
            else
            {
                return status = f.Contain > 0;
            }
        }
        public int Power
        {
            get
            {
                return power;
            }
            set
            {
                power = value;
            }
        }
        public string Mark
        {
            get
            {
                return mark;
            }
            set
            {
                mark = value;
            }
        }
        public int Consuming
        {
            get
            {
                return consuming;
            }
            set
            {
                consuming = value;
            }
        }
        public bool Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
    }
}
