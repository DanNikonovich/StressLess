using System;

namespace matemat1
{
    class Program
    {
        // Объявление переменной x и присвоение ей значения, введенного пользователем
        static void Main()
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            // Объявление переменной y и присвоение ей значения, введенного пользователем
            Console.Write("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            // Объявление переменной z и присвоение ей значения, введенного пользователем
            Console.Write("Введите z: ");
            double z = Convert.ToDouble(Console.ReadLine());

            // Вычисление значения переменной a
            double a = Math.Sqrt(y - Math.Abs(x)) * (x - Math.Sin(x + y));

            // Вычисление значения переменной b
            double b = Math.Cos(z) + (x * x / 4);

            // Вывод результатов на консоль
            Console.WriteLine($"a: {a:F2}, b: {b:F2}");
        }
    }
}
