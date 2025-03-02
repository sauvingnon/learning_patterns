using AbstractFactory.Interface;

namespace AbstractFactory
{
    public class Client
    {
        private readonly IChair _chair;
        private readonly ITable _table;

        public Client(IFurnitureFactory factory)
        {
            _chair = factory.CreateChair();
            _table = factory.CreateTable();
        }

        public void UseFurniture()
        {
            _chair.SitOn();
            _table.PutOn();
        }
    }
}
