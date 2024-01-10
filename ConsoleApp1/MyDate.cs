using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyDate
    {
        Exceptions Exception = new Exceptions();
        public int Year { get; protected set; }
        public int Month { get; protected set; }
        public int Day { get; protected set; }
        public int Hour { get; protected set; }
        public int Minute { get; protected set; }
        public MyDate(int year, int month, int day, int hour, int minute)
        {
            if (year < 0 || 13 < month || month < 0 || day < 0 || day > 31 || hour < 0 || hour > 24 || minute < 0 || minute >60)
                Exception.IncorectIntDate();
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
            Minute = minute;
        }
        public MyDate(int month, int day)
        {
            if (12 < month || month < 0 || day < 0 || day > 31)
                Exception.IncorectIntDate();
            Month = month;
            Day = day;
        }
        public MyDate(int day, int hour, int minute)
        {
            if (day < 0 || day > 31 || hour < 0 || hour > 24 || minute < 0 || minute > 60)
                Exception.IncorectIntDate();
            Day = day;
            Hour = hour;
            Minute = minute;
        }
        public MyDate()
        {
            Year = 2000;
            Month = 1;
            Day = 1;
            Hour = 0;
            Minute = 0;
        }
        public MyDate(MyDate myDate)
        {
            Year = myDate.Year;
            Month = myDate.Month;
            Day = myDate.Day;
            Hour = myDate.Hour;
            Minute = myDate.Minute;
        }
    }
}
