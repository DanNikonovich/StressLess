using System;
class TwoDimensionalArray
{
    private int[,] array;
    public TwoDimensionalArray(int[,] inputArray)
    {
        array = inputArray;
    }
    // Метод для проверки, является ли элемент массива палиндромом
    public bool IsElementPalindrome(int row, int col)
    {
        int value = array[row, col];
        string valueAsString = value.ToString();
        // Проверяем, что значение одинаково при чтении справа налево и слева направо
        for (int i = 0; i < valueAsString.Length / 2; i++)
        {
            if (valueAsString[i] != valueAsString[valueAsString.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }

    // Метод для вывода массива
    public void PrintArray()
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        Console.WriteLine("Двумерный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        // Пример создания двумерного массива
        int[,] myArray = {
            { 121, 234, 345 },
            { 456, 787, 123 },
            { 321, 111, 222 }
        };

        TwoDimensionalArray arrayHandler = new TwoDimensionalArray(myArray);
        // Выводим массив
        arrayHandler.PrintArray();
        // Запрашиваем строку и столбец для проверки
        Console.Write("Введите номер строки: ");
        int rowToCheck = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int colToCheck = int.Parse(Console.ReadLine());
        // Проверяем элемент на палиндром
        bool isPalindrome = arrayHandler.IsElementPalindrome(rowToCheck, colToCheck);

        if (isPalindrome)
        {
            Console.WriteLine($"Элемент [{rowToCheck}, {colToCheck}] со значением {myArray[rowToCheck, colToCheck]} является палиндромом.");
        }
        else
        {
            Console.WriteLine($"Элемент [{rowToCheck}, {colToCheck}] со значением {myArray[rowToCheck, colToCheck]} не является палиндромом.");
        }
    }
}
