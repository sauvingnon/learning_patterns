using Prototype.ConcretePrototype;
using Prototype.Prototype;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card prototype = new DragonCard();
            Card clone = prototype.Clone();
            Console.WriteLine($"Имя клона: {clone.Name}");

            prototype = new OldMasterCard();
            clone = prototype.Clone();
            Console.WriteLine($"Имя клона: {clone.Name}");
        }
    }
}
