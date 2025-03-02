namespace AbstractFactory.Interface
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ITable CreateTable();
    }
}
