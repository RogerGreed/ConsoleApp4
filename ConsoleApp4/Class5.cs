using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
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
