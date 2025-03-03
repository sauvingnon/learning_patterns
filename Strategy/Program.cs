using Strategy.ConcreteStrategy;
using Strategy.Context;

namespace Strategy
{
    internal class Program
    {
        /// <summary>
        /// Существуют различные легковые машины,
        /// которые используют разные источники энергии:
        /// электричество, бензин, газ и так далее.
        /// Есть гибридные автомобили. В целом они похожи
        /// и отличаются преимущественно видом источника энергии.
        /// Не говоря уже о том, что мы можем изменить применяемый
        /// источник энергии, модифицировав автомобиль.
        /// </summary>
        static void Main(string[] args)
        {
            Car auto = new Car(4, "Tesla", new PetrolMove());
            auto.Move();
            auto.Movable = new ElectricMove();
            auto.Move();

            Console.ReadLine();
        }
    }
}
