using AbstractFactory.Interface;

namespace AbstractFactory.Products
{
    // Современный стол
    public class ModernTable : ITable
    {
        public void PutOn()
        {
            Console.WriteLine("Ставим что-то на современный стол.");
        }
    }
}
