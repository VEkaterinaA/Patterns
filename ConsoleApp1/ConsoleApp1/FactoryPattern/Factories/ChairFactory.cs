using ConsoleApp1.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FactoryPattern.Factories
{
    public class ChairFactory: FurnitureFactory
    {
        private readonly int _price;

        public ChairFactory(int price)
        {
            _price = price;
        }
        public override IFurniture GetFurniture()
        {
            Chair chair = new(_price);
            return chair;
        }
    }
}
