using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите символ функции (sin, cos, tg, ctg): ");
        string function = Console.ReadLine().Trim().ToLower();

        Console.Write("Введите значение аргумента (в радианах): ");
        if (!double.TryParse(Console.ReadLine(), out double x))
        {
            Console.WriteLine("Неверный ввод для значения аргумента.");
            return;
        }

        double result = 0;
        string comment = "";

        switch (function)
        {
            case "sin":
                result = Math.Sin(x);
                comment = "Синус заданного угла.";
                break;
            case "cos":
                result = Math.Cos(x);
                comment = "Косинус заданного угла.";
                break;
            case "tg":
                result = Math.Tan(x);
                comment = "Тангенс заданного угла.";
                break;
            case "ctg":
                if (Math.Tan(x) != 0)
                {
                    result = 1.0 / Math.Tan(x);
                    comment = "Котангенс заданного угла.";
                }
                else
                {
                    Console.WriteLine("Котангенс не определен для этого угла (разделение на ноль).");
                    return;
                }
                break;
            default:
                Console.WriteLine("Неверный символ функции.");
                return;
        }

        Console.WriteLine($"Результат: {result}");
        Console.WriteLine(comment);
    }
}
