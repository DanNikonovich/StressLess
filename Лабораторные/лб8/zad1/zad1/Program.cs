// double; IxF0, IxF1 возвращают Log(w), F0 F1 возвращают Неявная реализация 2/w, явная реа-
//лизация w^3
using System;
using System.Collections.Generic;

interface Ix
{
    void IxF0(double param);
    void IxF1();
}

interface Iy
{
    void F0(double param);
    void F1();
}

interface Iz
{
    void F0(double param);
    void F1();
}

class TestClass : Ix, Iy, Iz
{
    private double w;

    // Неявная реализация методов интерфейсов Ix, Iy и Iz
    public void IxF0(double param)
    {
        Console.WriteLine($"Log(w) = {Math.Log(w)}");
    }

    public void IxF1()
    {
        Console.WriteLine($"2/w = {2 / w}");
    }

    void Iy.F0(double param)
    {
        Console.WriteLine($"2/w = {2 / w} (неоднозначная реализация)");
    }

    void Iy.F1()
    {
        Console.WriteLine("Вызван метод F1() интерфейса Iy");
    }

    // Явная реализация интерфейса Iz
    void Iz.F0(double param)
    {
        Console.WriteLine($"w^3 = {Math.Pow(w, 3)}");
    }

    void Iz.F1()
    {
        Console.WriteLine("Вызван метод F1() интерфейса Iz");
    }

    public TestClass(double w)
    {
        this.w = w;
    }
}

class Program
{
    static void Main(string[] args)
    {
        double w = 5.0; // Произвольное значение параметра w
        TestClass testObject = new TestClass(w);

        // Вызов методов через интерфейсные ссылки
        Ix ix = testObject;
        Iy iy = testObject;
        Iz iz = testObject;

        ix.IxF0(w);
        ix.IxF1();

        iy.F0(w);
        iy.F1();

        iz.F0(w);
        iz.F1();
    }
}

