namespace Sigleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var instance_1 = Singleton.GetInstance();
            var instance_2 = Singleton.GetInstance();

            var compareResult = ReferenceEquals(instance_1, instance_2);
            Console.WriteLine(compareResult);
        }
    }
}
