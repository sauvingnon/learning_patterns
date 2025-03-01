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
    /// Конкретнй класс ConcreteCreatorB - наследники класса Creator,
    /// определяющий свою реализацию метода FactoryMethod().
    /// Причем метод FactoryMethod() каждого отдельного класса-создателя
    /// возвращает определенный конкретный тип продукта.
    /// Для каждого конкретного класса продукта определяется свой конкретный класс создателя.
    /// </summary>
    public class PanelHouseDeveloper : Developer
    {
        public PanelHouseDeveloper(string name) : base(name)
        {
        }

        public override House Create()
        {
            return new PanelHouse();
        }
    }
}
