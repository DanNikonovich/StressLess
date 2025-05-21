//Описать класс, представляющий четырехугольник. Разработать методы
//для определения является ли четырехугольник параллелограммом.

using System;

class Quadrilateral
{
    // Поля для хранения координат вершин четырехугольника
    private double x1, y1;
    private double x2, y2;
    private double x3, y3;
    private double x4, y4;

    // Конструктор с параметрами для инициализации вершин
    public Quadrilateral(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
        this.x3 = x3;
        this.y3 = y3;
        this.x4 = x4;
        this.y4 = y4;
    }

    // Метод для определения, является ли четырехугольник параллелограммом
    public bool IsParallelogram()
    {
        // Проверяем, что противоположные стороны параллельны
        double slope1 = (y2 - y1) / (x2 - x1);
        double slope2 = (y4 - y3) / (x4 - x3);

        return Math.Abs(slope1 - slope2) < 0.0001;
    }

    // Метод для ввода координат вершин
    // Метод для ввода координат вершин
    public static Quadrilateral InputQuadrilateral()
    {
        try
        {
            Console.WriteLine("Введите координаты вершин четырехугольника:");
            Console.Write("x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write("x3: ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("y3: ");
            double y3 = double.Parse(Console.ReadLine());
            Console.Write("x4: ");
            double x4 = double.Parse(Console.ReadLine());
            Console.Write("y4: ");
            double y4 = double.Parse(Console.ReadLine());

            return new Quadrilateral(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Ошибка формата ввода: " + ex.Message);
            return null; // Возвращаем null в случае ошибки
        }
    }
}

class Program
{
    static void Main()
    {
        // Вводим координаты вершин четырехугольника
        Quadrilateral quad = Quadrilateral.InputQuadrilateral();

        // Проверяем, является ли он параллелограммом
        if (quad.IsParallelogram())
        {
            Console.WriteLine("Четырехугольник является параллелограммом.");
        }
        else
        {
            Console.WriteLine("Четырехугольник не является параллелограммом.");
        }
    }
}

