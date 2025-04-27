using System;

class DRomb
{
    // Поля
    protected int d1;  // Перша діагональ
    protected int d2;  // Друга діагональ
    protected int color;  // Колір ромба

    // Конструктор
    public DRomb(int d1, int d2, int color)
    {
        this.d1 = d1;
        this.d2 = d2;
        this.color = color;
    }

    // Методи

    // Виведення довжин діагоналей
    public void PrintDimensions()
    {
        Console.WriteLine($"Діагоналі ромба: d1 = {d1}, d2 = {d2}");
    }

    // Обчислення периметра ромба
    public double CalculatePerimeter()
    {
        // Периметр ромба: P = 4 * a, де a - сторона ромба
        double a = Math.Sqrt(Math.Pow(d1 / 2.0, 2) + Math.Pow(d2 / 2.0, 2)); // Сторона ромба за теоремою Піфагора
        return 4 * a;
    }

    // Обчислення площі ромба
    public double CalculateArea()
    {
        return (d1 * d2) / 2.0;
    }

    // Перевірка, чи є ромб квадратом
    public bool IsSquare()
    {
        return d1 == d2;
    }

    // Властивості
    public int D1
    {
        get { return d1; }
        set { d1 = value; }
    }

    public int D2
    {
        get { return d2; }
        set { d2 = value; }
    }

    public int Color
    {
        get { return color; }
    }
}

class Program
{
    static void Main()
    {
        // Створення масиву ромбів
        DRomb[] rhombuses = new DRomb[]
        {
            new DRomb(10, 20, 1),
            new DRomb(15, 15, 2),
            new DRomb(25, 30, 3)
        };

        int squareCount = 0; // Лічильник квадратів

        // Обробка кожного ромба
        foreach (var rhombus in rhombuses)
        {
            Console.WriteLine($"Ромб з кольором {rhombus.Color}:");
            rhombus.PrintDimensions();
            Console.WriteLine($"Площа: {rhombus.CalculateArea()}");
            Console.WriteLine($"Периметр: {rhombus.CalculatePerimeter()}");

            // Перевірка, чи є ромб квадратом
            if (rhombus.IsSquare())
            {
                Console.WriteLine("Це квадрат.");
                squareCount++;
            }
            else
            {
                Console.WriteLine("Це не квадрат.");
            }

            Console.WriteLine();
        }

        // Виведення кількості квадратів
        Console.WriteLine($"Кількість квадратів: {squareCount}");
    }
}
