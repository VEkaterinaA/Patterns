using ConsoleApp1.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FactoryPattern.Factories
{
    public abstract class FurnitureFactory
    {
        public abstract IFurniture GetFurniture();
    }
}
