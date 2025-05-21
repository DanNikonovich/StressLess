using System;

// Базовый класс (родительский класс)
class Vector
{
    protected string name; // Название вектора
    // Конструктор с параметрами
    public Vector(string name)
    {
        this.name = name;
    }
    // Виртуальный метод для расчета длины вектора
    public virtual double CalculateLength()
    {
        return 0; // Базовый вектор имеет нулевую длину
    }

    // Метод для вывода информации о векторе
    public void DisplayInfo()
    {
        Console.WriteLine($"Вектор \"{name}\":");
        Console.WriteLine($"Длина вектора: {CalculateLength()}");
    }
}

// Производный класс (потомок) для двумерных векторов
class TwoDimensionalVector : Vector
{
    private double x; // Компонента x
    private double y; // Компонента y
    public TwoDimensionalVector(string name, double x, double y)
        : base(name)
    {
        this.x = x;
        this.y = y;
    }
    // Переопределение метода CalculateLength
    public override double CalculateLength()
    {
        return Math.Sqrt(x * x + y * y);
    }
}

// Производный класс (потомок) для трехмерных векторов
class ThreeDimensionalVector : Vector
{
    private double x; // Компонента x
    private double y; // Компонента y
    private double z; // Компонента z
    public ThreeDimensionalVector(string name, double x, double y, double z)
        : base(name)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    // Переопределение метода CalculateLength
    public override double CalculateLength()
    {
        return Math.Sqrt(x * x + y * y + z * z);
    }
}

class Program
{
    static void Main()
    {
        Vector[] vectors = new Vector[5]; // Создаем массив объектов базового класса

        vectors[0] = new TwoDimensionalVector("2D вектор 1", 3, 4);
        vectors[1] = new TwoDimensionalVector("2D вектор 2", 1, 7);
        vectors[2] = new ThreeDimensionalVector("3D вектор 1", 1, 2, 3);
        vectors[3] = new ThreeDimensionalVector("3D вектор 2", 4, 5, 6);
        vectors[4] = new TwoDimensionalVector("2D вектор 3", 8, 2);

        // Выводим информацию о векторах
        foreach (var vector in vectors)
        {
            vector.DisplayInfo();
        }

        // Вычисляем суммарную длину векторов
        double totalLength = 0;
        foreach (var vector in vectors)
        {
            totalLength += vector.CalculateLength();
        }

        Console.WriteLine($"Суммарная длина всех векторов: {totalLength}");
    }
}