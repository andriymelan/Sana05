﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyDate
    {
            public int Year { get; protected set; }
            public int Month { get; protected set; }
            public int Day { get; protected set; }
            public int Hour { get; protected set; }
            public int Minute { get; protected set; }
            public MyDate(int year, int month, int day, int hour, int minute)
            {
                Year = year;
                Month = month;
                Day = day;
                Hour = hour;
                Minute = minute;
            }        
    }
}