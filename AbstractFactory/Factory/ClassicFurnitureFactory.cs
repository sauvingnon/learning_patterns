using AbstractFactory.Interface;
using AbstractFactory.Products;

namespace AbstractFactory.Factory
{
    // Фабрика для создания классической мебели
    public class ClassicFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ClassicChair();
        }

        public ITable CreateTable()
        {
            return new ClassicTable();
        }
    }
}
