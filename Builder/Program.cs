using System.IO;
using System.Numerics;
using Builder.Builders.Implementations;
using Builder.Builders.Interfaces;
using Builder.Directors;
using Builder.Entity;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Создаем андроид разработчика
            IDeveloper androidDeveloper = new AndroidDeveloper();

            // Соаздаем IOS разработчика
            IDeveloper iosDeveloper = new IPhoneDeveloper();

            // Создаем распорядителя, который будет управлять разработчиками
            Director director = new Director(androidDeveloper);
            // Директор выпускает с помощью андроид разработчика
            // телефон, причем без ОС
            Phone samsung = director.MountOnlyPhone();
            Console.WriteLine(samsung.AboutPhone());
            // Замена разработчика
            director.SetDeveloper(iosDeveloper);
            // Выпуск телефона (с ОС)
            Phone iPhone = director.MountFullPhone();
            Console.WriteLine(iPhone.AboutPhone());
            Console.Read();
        }
    }
}
