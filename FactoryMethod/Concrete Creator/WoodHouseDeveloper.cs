using FactoryMethod.Concrete_Product;
using FactoryMethod.Creator;
using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete_Creator
{
    /// <summary>
    /// Конкретнй класс ConcreteCreatorA - наследники класса Creator,
    /// определяющий свою реализацию метода FactoryMethod().
    /// Причем метод FactoryMethod() каждого отдельного класса-создателя
    /// возвращает определенный конкретный тип продукта.
    /// Для каждого конкретного класса продукта определяется свой конкретный класс создателя.
    /// </summary>
    public class WoodHouseDeveloper : Developer
    {
        public WoodHouseDeveloper(string name) : base(name)
        {
        }

        public override House Create()
        {
            return new WoodHouse();
        }
    }
}
