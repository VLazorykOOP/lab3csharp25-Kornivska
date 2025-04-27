using System;

class DRomb
{
    protected int d1;
    protected int d2;
    protected int color;

    public DRomb(int d1, int d2, int color)
    {
        this.d1 = d1;
        this.d2 = d2;
        this.color = color;
    }

    public void PrintDimensions()
    {
        Console.WriteLine($"Діагоналі ромба: d1 = {d1}, d2 = {d2}");
    }

    public double CalculatePerimeter()
    {
        double a = Math.Sqrt(Math.Pow(d1 / 2.0, 2) + Math.Pow(d2 / 2.0, 2));
        return 4 * a;
    }

    public double CalculateArea()
    {
        return (d1 * d2) / 2.0;
    }

    public bool IsSquare()
    {
        return d1 == d2;
    }

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
        DRomb[] rhombuses = new DRomb[]
        {
            new DRomb(10, 20, 1),
            new DRomb(15, 15, 2),
            new DRomb(25, 30, 3)
        };

        int squareCount = 0;

        foreach (var rhombus in rhombuses)
        {
            Console.WriteLine($"Ромб з кольором {rhombus.Color}:");
            rhombus.PrintDimensions();
            Console.WriteLine($"Площа: {rhombus.CalculateArea()}");
            Console.WriteLine($"Периметр: {rhombus.CalculatePerimeter()}");

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

        Console.WriteLine($"Кількість квадратів: {squareCount}");
    }
}
