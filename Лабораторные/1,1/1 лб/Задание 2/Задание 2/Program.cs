using System;
namespace LR1T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введите z: ");
            double z = double.Parse(Console.ReadLine());
            double a = (y - Math.Sqrt(Math.Abs(x)))*(x - Math.Sin(x+y));
            Console.WriteLine("a= {0}", a);
            double b = Math.Cos(Math.Pow(z, 2)+(Math.Pow(x, 2)/4));
            Console.WriteLine("b= {0}", b);
        }
    }
}
