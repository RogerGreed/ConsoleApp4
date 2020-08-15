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
        public void Add(Wheel wheel)
        {
            wheels.Add(wheel);
        }
        public void Remove(Wheel wheel)
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
                    return status;
                }
            }
            status = true;
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
