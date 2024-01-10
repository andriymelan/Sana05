using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Currency
    {
        protected string Name { get; set; }
        public float ExRate { get; protected set; }
        public Currency(string name, string exRate) 
        {
            Name = name;
            float.TryParse(exRate, out float ExRatee);
            ExRate = ExRatee;
        }
    }
}
