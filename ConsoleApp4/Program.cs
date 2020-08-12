using System;
using System.Collections.Generic;

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
        public ERROR_ID starting(Engine e, Fuelstorage f, Wheels w)
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
    class Fuelstorage
    {
        private int durability;
        private double contain;
        private bool status;

        public Fuelstorage(int d, double c, bool s)
        {
            durability = d;
            contain = c;
            status = s;
        }


        public double refuel()
        {
            if (contain > 10.0)
            {
                contain = durability;
            }
            return contain;
        }
        public int Durability
        {
            get
            {
                return durability;
            }
            set
            {
                durability = value;
            }
        }
        public double Contain
        {
            get
            {
                return contain;
            }
            set
            {
                contain = value;
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
    class Creation
    {
        private string mark;
        private DateTime date;
        private string place;

        public Creation()
        {
            date = new DateTime();
        }
        public Creation(string m, string p)
        {
            mark = m;
            place = p;
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
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public string Place
        {
            get
            {
                return place;
            }
            set
            {
                place = value;
            }
        }
    }
    class Wheel
    {
        private double pressure;
        private string position;
        private bool status;
        

        public Wheel(double p, string po, bool s)
        {
            pressure = p;
            position = po;
            status = s;
        }

        public double Pressure
        {
            get
            {
                return pressure;
            }
            set
            {
                pressure = value;
            }
        }
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
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
    class Wheels
    {
        private bool status;
        private List<Wheel> wheels;
        public Wheels()
        {
            wheels = new List<Wheel>();
        }
        public void add(Wheel wheel)
        {
            wheels.Add(wheel);
        }
        public void remove(Wheel wheel)
        {
            wheels.Remove(wheel);
        }
        public bool WheelsStatus()
        {
            foreach (Wheel wheel in this.wheels)
            {
                if (wheel.Status == false)
                {
                    status = false;
                    break;
                }
            }
            return status;
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
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
