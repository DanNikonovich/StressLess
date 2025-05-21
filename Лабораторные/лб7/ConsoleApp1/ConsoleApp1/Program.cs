using System;

// Базовый класс (родительский класс)
class Vector
{
    private string name; // Название вектора

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
        // Создаем объекты базового и производных классов
        Vector baseVector = new Vector("Базовый вектор");
        TwoDimensionalVector twoDVector = new TwoDimensionalVector("2D вектор", 3, 4);
        ThreeDimensionalVector threeDVector = new ThreeDimensionalVector("3D вектор", 1, 2, 3);

        // Создаем массив ссылок на базовый класс
        Vector[] vectors = { baseVector, twoDVector, threeDVector };

        // Выводим информацию о векторах
        foreach (var vector in vectors)
        {
            vector.DisplayInfo();
        }
    }
}
