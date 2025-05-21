using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");

        if (!int.TryParse(Console.ReadLine(), out int number) || number <= 0)
        {
            Console.WriteLine("Введите корректное натуральное число.");
            return;
        }

        if (number % 2 == 0)
        {
            // Четное число: вычисляем сумму цифр
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10; // Получаем последнюю цифру
                number /= 10;       // Убираем последнюю цифру
            }

            Console.WriteLine($"Сумма цифр: {sum}");
        }
        else
        {
            // Нечетное число: вычисляем остаток от деления на 10
            int remainder = number % 10;
            Console.WriteLine($"Остаток от деления на 10: {remainder}");
        }
    }
}
