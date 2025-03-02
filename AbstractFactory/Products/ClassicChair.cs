using AbstractFactory.Interface;

namespace AbstractFactory.Products
{
    // Классический стул
    public class ClassicChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Сидим на классическом стуле.");
        }
    }

}
