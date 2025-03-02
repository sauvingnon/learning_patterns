using Prototype.ConcretePrototype;
using Prototype.Prototype;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем прототип
            Card prototype = new DragonCard();
            // Получаем его клона
            Card clone = prototype.Clone();
            // Он обладает всем тем же, что и оригинал
            Console.WriteLine($"Имя клона: {clone.Name}");

            prototype = new OldMasterCard();
            clone = prototype.Clone();
            Console.WriteLine($"Имя клона: {clone.Name}");

            // Стоит отличать поверхностное копирование
            // от глубокого копирования.
            // В данном случае реализовано поверхностное копирования.
            // Глубокое копирование требует от метода 
            // записи всех пустых полей и ссылок на необходимые значения
            // для клона, чтобы быть в точности похожим на оригинал.
        }
    }
}
