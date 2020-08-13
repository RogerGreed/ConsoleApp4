using System;
using System.Collections.Generic;
using System.Text;
using FuelstorageCs;

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

        public bool start()
        {
            return status;
        }

        public bool start(Fuelstorage f)
        {
            return f.Contain > 0;
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
