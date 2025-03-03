using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
    /// <summary>
    /// Интерфейс IStrategy, который определяет метод Algorithm().
    /// Это общий интерфейс для всех реализующих его алгоритмов.
    /// Вместо интерфейса здесь также можно было бы использовать абстрактный класс.
    /// </summary>
    public interface IMovable
    {
        void Move();
    }
}
