using FactoryMethod.Concrete_Creator;
using FactoryMethod.Creator;

namespace FactoryMethod
{
    internal class Program
    {
        // Допустим, мы создаем программу для сферы строительства.
        // Возможно, вначале мы захотим построить многоэтажный панельный дом.
        // И для этого выбирается соответствующий подрядчик,
        // который возводит каменные дома.
        // Затем нам захочется построить деревянный дом и для этого также надо будет
        // выбрать нужного подрядчика.
        static void Main(string[] args)
        {
            Developer developer = new WoodHouseDeveloper("ООО Дубострой");
            developer.Create();

            developer = new PanelHouseDeveloper("ЗАО Пенапанели");
            developer.Create();
        }
    }
}
