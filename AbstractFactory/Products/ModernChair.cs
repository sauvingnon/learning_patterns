using AbstractFactory.Interface;

namespace AbstractFactory.Products
{
    // Современный стул
    public class ModernChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Сидим на современном стуле.");
        }
    }
}
