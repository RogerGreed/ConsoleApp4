using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
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
}
