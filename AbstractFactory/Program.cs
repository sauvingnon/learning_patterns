using AbstractFactory.Factory;
using AbstractFactory.Interface;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем современную мебель
            IFurnitureFactory modernFactory = new ModernFurnitureFactory();
            Client modernClient = new Client(modernFactory);
            modernClient.UseFurniture();

            // Создаем классическую мебель
            IFurnitureFactory classicFactory = new ClassicFurnitureFactory();
            Client classicClient = new Client(classicFactory);
            classicClient.UseFurniture();
        }
    }
}
