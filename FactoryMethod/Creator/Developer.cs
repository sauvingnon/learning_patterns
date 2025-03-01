using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creator
{
    /// <summary>
    /// Абстрактный класс Creator определяет
    /// абстрактный фабричный метод FactoryMethod()
    /// </summary>
    public abstract class Developer
    {
        public string Name { get; set; }
        public Developer(string name)
        {
            this.Name = name;
        }
        /// <summary>
        /// Фабричный метод FactoryMethod()
        /// </summary>
        /// <returns>Объект Product (House)</returns>
        public abstract House Create();
    }
}
