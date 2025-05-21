//Программа запрашивает натуральное число, вычисляет сумму его цифр
//и выводит результат в зависимости от четности числа. Если сумма цифр четная, выводится ее значение.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Число должно быть натуральным.");
            return;
        }

        int sum = 0;

        // Вычисление суммы цифр
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        // Проверка на четность
        if (sum % 2 == 0)
        {
            Console.WriteLine($"Сумма цифр числа: {sum}");
        }
        else
        {
            int remainder = sum % 10;
            Console.WriteLine($"Остаток от деления суммы цифр на 10: {remainder}");
        }
    }
}
