using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Currency
    {
        Exceptions Exception = new Exceptions();
        protected string Name { get; set; }
        public float ExRate { get; protected set; }
        public Currency(string name, string exRate) 
        {
            if (name == "" || exRate == "")
                Exception.IncorectIntDate();
            Name = name;
            float.TryParse(exRate, out float ExRatee);
            if (ExRatee < 0)
                Exception.IncorectIntDate();
            ExRate = ExRatee;
        }
        public Currency() 
        {
            Name = "UAH";
            ExRate = 1;
        }
        public Currency(Currency currency)
        {
            Name = currency.Name;
            ExRate = currency.ExRate;
        }
        public Currency(string name)
        {
            if (name == "")
                Exception.IncorectIntDate();
            Name = name;
        }
    }
}
