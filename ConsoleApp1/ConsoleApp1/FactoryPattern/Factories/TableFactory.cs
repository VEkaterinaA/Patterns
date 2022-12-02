using ConsoleApp1.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FactoryPattern.Factories
{
    public class TableFactory:FurnitureFactory
    {
        private readonly int _price;

        public TableFactory(int price)
        {
            _price = price;
        }
        public override IFurniture GetFurniture()
        {
            Table table = new(_price);
            return table;
        }
    }
}
