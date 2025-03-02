using AbstractFactory.Interface;

namespace AbstractFactory.Products
{
    // Классический стол
    public class ClassicTable : ITable
    {
        public void PutOn()
        {
            Console.WriteLine("Ставим что-то на классический стол.");
        }
    }
}
