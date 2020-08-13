using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
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
}

