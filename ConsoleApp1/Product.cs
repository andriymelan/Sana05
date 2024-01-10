using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Product
    {
        protected string Name {  get; set; }
        protected float Price {  get; set; }
        protected Currency Cost {  get; set; }
        protected int Quantity {  get; set; }
        protected string Producer {  get; set; }
        protected float Weight {  get; set; }
        public Product(string name, string price, Currency cost, int quantity, string producer, string weight)
        {
            Name = name;
            float.TryParse(price, out float Pricee);
            Price = Pricee;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            float.TryParse(weight, out float Weightt);
            Weight = Weightt;
        }
        public Product()
        {
            Name = "anonym";
            Price = 100;
            Cost = new Currency("UAH","1");
            Quantity = 1;
            Producer = "anonym";
            Weight = 1;
        }
        public Product(Product product) 
        {
            Name = product.Name;
            Price = product.Price;
            Cost = product.Cost;
            Quantity = product.Quantity;
            Producer = product.Producer;
            Weight = product.Weight;
        }
        public float GetPriceInUAH()
        {
            return Cost.ExRate * Price;
        }
        public float GetTotalPriceInUAH()
        {
            return GetPriceInUAH() * Quantity;
        }
        public float GetTotalWeight()
        {
            return Quantity * Weight;
        }
    }
}
