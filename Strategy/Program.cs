using Strategy.ConcreteStrategy;
using Strategy.Context;

namespace Strategy
{
    internal class Program
    {
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
