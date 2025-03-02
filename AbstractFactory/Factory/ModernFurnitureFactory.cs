using AbstractFactory.Interface;
using AbstractFactory.Products;

namespace AbstractFactory.Factory
{
    // Фабрика для создания современной мебели
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ITable CreateTable()
        {
            return new ModernTable();
        }
    }

}
