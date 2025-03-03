using Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.ConcreteStrategy
{
    /// <summary>
    /// ConcreteStrategy, который реализует интерфейс
    /// IStrategy, предоставляя свою версию метода Algorithm().
    /// Подобных классов-реализаций может быть множество.
    /// </summary>
    public class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на электричестве");
        }
    }
}
