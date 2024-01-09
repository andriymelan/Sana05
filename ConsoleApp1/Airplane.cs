﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Airplane
    {
        protected string StartCity { get; set; }
        protected string FinishCity { get; set; }
        protected MyDate StartDate { get; set; }
        protected MyDate FinishDate { get; set; }
        public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }
        public TimeSpan GetTotalTime()
        {
            DateTime startDate = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, StartDate.Hour, StartDate.Minute, 0);
            DateTime finishDate = new DateTime(FinishDate.Year, FinishDate.Month, FinishDate.Day, FinishDate.Hour, FinishDate.Minute, 0);
            return finishDate - startDate;
        }
        public bool IsArrivingToday()
        {
            return StartDate.Year == FinishDate.Year && StartDate.Month == FinishDate.Month && StartDate.Day == FinishDate.Day;
        }
    }
}