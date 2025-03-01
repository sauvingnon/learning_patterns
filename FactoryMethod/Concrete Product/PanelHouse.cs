using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete_Product
{
    public class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельный дом построен!");
        }
    }
}
