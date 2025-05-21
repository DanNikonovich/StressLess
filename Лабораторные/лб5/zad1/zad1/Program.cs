// Описать класс для работы с одномерным массивом вещественных чисел.
//Обеспечить следующие возможности: нахождение суммы элементов
//массива (перегрузка операции +).
using System;

namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int size = int.Parse(Console.ReadLine());

            // Создаем массив вещественных чисел
            double[] myArray = new double[size];

            // Вводим значения для массива
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                myArray[i] = double.Parse(Console.ReadLine());
            }

            // Создаем объект класса для работы с массивом
            ArrayCalculator calculator = new ArrayCalculator(myArray);

            // Вычисляем сумму элементов массива
            double sum = calculator.CalculateSum();

            Console.WriteLine($"Сумма элементов массива: {sum}");
        }
    }

    class ArrayCalculator
    {
        private double[] array;

        // Конструктор, принимающий массив в качестве параметра
        public ArrayCalculator(double[] inputArray)
        {
            array = inputArray;
        }

        // Перегрузка операции сложения для массивов
        public static double operator +(ArrayCalculator calc, double value)
        {
            double sum = calc.CalculateSum();
            return sum + value;
        }

        // Метод для вычисления суммы элементов массива
        public double CalculateSum()
        {
            double sum = 0;
            foreach (double element in array)
            {
                sum += element;
            }
            return sum;
        }
    }
}
