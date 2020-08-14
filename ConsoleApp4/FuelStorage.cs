using System;
using System.Collections.Generic;
using System.Text;

namespace FuelStorageCs
{
    class FuelStorage
    {
        private int durability;
        private double contain;
        private bool status;

        public FuelStorage(int d, double c, bool s)
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
}
