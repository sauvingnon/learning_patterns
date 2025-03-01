using FactoryMethod.Concrete_Creator;
using FactoryMethod.Creator;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new WoodHouseDeveloper("ООО Дубострой");
            developer.Create();

            developer = new PanelHouseDeveloper("ЗАО Пенапанели");
            developer.Create();
        }
    }
}
