//Программа предлагает ввести символ (s - sin, c - cos, t - tg, g - ctg)
//и значение аргумента x. Затем она вычисляет соответствующую функцию и выводит результат на экран.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите символ (s - sin, c - cos, t - tg, g - ctg): ");
        char symbol = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Введите значение аргумента x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double result = 0;
        string comment = "";

        switch (symbol)
        {
            case 's':
                result = Math.Sin(x);
                comment = "Значение sin(x)";
                break;
            case 'c':
                result = Math.Cos(x);
                comment = "Значение cos(x)";
                break;
            case 't':
                result = Math.Tan(x);
                comment = "Значение tg(x)";
                break;
            case 'g':
                result = 1 / Math.Tan(x);
                comment = "Значение ctg(x)";
                break;
            default:
                Console.WriteLine("Некорректный символ. Введите s, c, t или g.");
                return;
        }

        Console.WriteLine($"{comment} = {result:F4}");
    }
}
