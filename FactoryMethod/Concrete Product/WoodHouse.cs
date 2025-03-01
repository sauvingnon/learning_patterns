using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete_Product
{
    /// <summary>
    /// Конкретный класс ConcreteProductB
    /// представляет реализацию класса Product.
    /// Таких классов может быть множество
    /// </summary>
    public class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревянный дом построен!");
        }
    }
}
