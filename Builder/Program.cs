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
            IDeveloper androidDeveloper = new AndroidDeveloper();

            IDeveloper iosDeveloper = new IPhoneDeveloper();

            Director director = new Director(androidDeveloper);
            Phone samsung = director.MountOnlyPhone();
            Console.WriteLine(samsung.AboutPhone());
            director.SetDeveloper(iosDeveloper);
            Phone iPhone = director.MountFullPhone();
            Console.WriteLine(iPhone.AboutPhone());
            Console.Read();
        }
    }
}
