//Базовый класс: Студент (поле: имя, средний балл s)
//Метод: Стипендия 300000 + 10000([s] - 5)
//Потомок: Магистр(поле – специальность)
//Изменения в потомках: Увеличить стипендию на m руб.

using System;

// Базовый класс (родительский класс)
class Student
{
    // Закрытые поля
    private string name;
    private double averageGrade;

    // Конструктор с параметрами
    public Student(string name, double averageGrade)
    {
        this.name = name;
        this.averageGrade = averageGrade;
    }

    // Метод доступа к закрытым полям
    public string GetName()
    {
        return name;
    }

    public double GetAverageGrade()
    {
        return averageGrade;
    }

    // Метод для расчета стипендии
    public double CalculateScholarship()
    {
        return 300000 + 10000 * (averageGrade - 5);
    }
}

// Производный класс (потомок)
class Master : Student
{
    // Дополнительное поле для специальности магистра
    private string specialty;

    // Конструктор с параметрами
    public Master(string name, double averageGrade, string specialty)
        : base(name, averageGrade)
    {
        this.specialty = specialty;
    }

    // Метод для увеличения стипендии на m рублей
    public double IncreaseScholarship(double m)
    {
        return CalculateScholarship() + m;
    }

    // Метод для вывода информации о магистре
    public void DisplayMasterInfo()
    {
        Console.WriteLine($"Магистр {GetName()}, специальность: {specialty}");
        Console.WriteLine($"Стипендия: {CalculateScholarship()} рублей");
    }
}

class Program
{
    static void Main()
    {
        // Создаем объект базового класса (Студент)
        Student student = new Student("Иван", 4.8);

        // Создаем объект производного класса (Магистр)
        Master master = new Master("Анна", 5.2, "Информационные технологии");

        // Выводим информацию о студенте и магистре
        Console.WriteLine("Информация о студенте:");
        Console.WriteLine($"Имя: {student.GetName()}, Средний балл: {student.GetAverageGrade()}");
        Console.WriteLine($"Стипендия: {student.CalculateScholarship()} рублей");

        Console.WriteLine("\nИнформация о магистре:");
        master.DisplayMasterInfo();

        // Увеличиваем стипендию магистра на 5000 рублей
        double increasedScholarship = master.IncreaseScholarship(5000);
        Console.WriteLine($"\nУвеличенная стипендия магистра: {increasedScholarship} рублей");
    }
}
