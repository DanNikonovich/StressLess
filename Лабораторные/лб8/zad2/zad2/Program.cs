using System;
using System.Collections.Generic;

// Класс, представляющий информацию о больном
class Patient : IComparable<Patient>
{
    public string FullName { get; set; }
    public string Disease { get; set; }
    public DateTime AdmissionDate { get; set; }
    public int WorkExperience { get; set; }

    // Реализация интерфейса IComparable для сравнения по ФИО
    public int CompareTo(Patient other)
    {
        return string.Compare(FullName, other.FullName, StringComparison.OrdinalIgnoreCase);
    }
}

class Program
{
    static void Main()
    {
        // Создаем список больных
        var patients = new List<Patient>
        {
            new Patient { FullName = "Иванов Иван Иванович", Disease = "Грипп", AdmissionDate = DateTime.Parse("2024-02-10"), WorkExperience = 5 },
            new Patient { FullName = "Петрова Ольга Сергеевна", Disease = "Ангина", AdmissionDate = DateTime.Parse("2024-02-15"), WorkExperience = 8 },
            new Patient { FullName = "Сидоров Павел Николаевич", Disease = "Простуда", AdmissionDate = DateTime.Parse("2024-02-12"), WorkExperience = 3 },
            // Добавьте еще больных по аналогии
        };

        // Фильтруем больных, находящихся на лечении больше недели
        var hospitalizedMoreThanWeek = patients.FindAll(p => (DateTime.Now - p.AdmissionDate).TotalDays > 7);

        // Сортируем по ФИО
        hospitalizedMoreThanWeek.Sort();

        // Выводим информацию о больных
        Console.WriteLine("Список больных, находящихся на лечении больше недели (по ФИО):");
        foreach (var patient in hospitalizedMoreThanWeek)
        {
            Console.WriteLine($"{patient.FullName}, болезнь: {patient.Disease}, дата поступления: {patient.AdmissionDate.ToShortDateString()}, стаж: {patient.WorkExperience} лет");
        }
    }
}
