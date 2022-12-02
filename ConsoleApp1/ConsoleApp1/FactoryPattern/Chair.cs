using ConsoleApp1.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Factory
{
    internal class Chair : IFurniture
    {
        int _price;
        string _name;
        public Chair(int price)
        {
            _price = price;
            _name = "chair";
        }

        public int GetPrice() => _price;
    }
}
