﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrador_de_Ventas
{
    internal class Fecha
    {
        private int day;
        private int month;
        private int year;

        public Fecha(int d, int m, int y)
        {
            day = d;
            month = m;
            year = y;
        }
        
        public int Day
        {
            get { return day;}
            set { day = value;}
        }
        public int Month
        {
            get { return month;}
            set { month = value;}
        }
        public int Year
        {
            get { return year;}
            set { year = value;}
        }

    }
}
