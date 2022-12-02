using ConsoleApp1.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Factory
{
    internal class Table: IFurniture
    {
        int _price;
        string _name;
        public Table(int price)
        {
            _price = price;
            _name = "table";
        }

        public int GetPrice() => _price;
    }
}
