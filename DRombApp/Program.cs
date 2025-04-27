using System;

// ПЕРШЕ ЗАВДАННЯ: Ромб

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

// ДРУГЕ ЗАВДАННЯ: Друковані видання

abstract class PrintedEdition
{
    public string Title { get; set; }
    public int Pages { get; set; }

    public PrintedEdition(string title, int pages)
    {
        Title = title;
        Pages = pages;
    }

    public abstract void Show();
}

class Book : PrintedEdition
{
    public string Author { get; set; }

    public Book(string title, int pages, string author) : base(title, pages)
    {
        Author = author;
    }

    public override void Show()
    {
        Console.WriteLine($"Книга: \"{Title}\", Автор: {Author}, Сторінок: {Pages}");
    }
}

class Magazine : PrintedEdition
{
    public int IssueNumber { get; set; }

    public Magazine(string title, int pages, int issueNumber) : base(title, pages)
    {
        IssueNumber = issueNumber;
    }

    public override void Show()
    {
        Console.WriteLine($"Журнал: \"{Title}\", Номер випуску: {IssueNumber}, Сторінок: {Pages}");
    }
}

class Textbook : PrintedEdition
{
    public string Subject { get; set; }

    public Textbook(string title, int pages, string subject) : base(title, pages)
    {
        Subject = subject;
    }

    public override void Show()
    {
        Console.WriteLine($"Підручник: \"{Title}\", Предмет: {Subject}, Сторінок: {Pages}");
    }
}

// ГОЛОВНА ПРОГРАМА

class Program
{
    static void Main()
    {
        Console.WriteLine("Виберіть завдання:");
        Console.WriteLine("1 - Робота з ромбами");
        Console.WriteLine("2 - Робота з друкованими виданнями");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            // Частина 1: РОМБИ
            Console.WriteLine("Частина 1: Робота з ромбами\n");

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

            Console.WriteLine($"Кількість квадратів: {squareCount}\n");
        }
        else if (choice == 2)
        {
            // Частина 2: ДРУКОВАНІ ВИДАННЯ
            Console.WriteLine("Частина 2: Робота з друкованими виданнями\n");

            PrintedEdition[] editions = new PrintedEdition[]
            {
                new Book("Тіні забутих предків", 220, "Михайло Коцюбинський"),
                new Magazine("Наука і життя", 98, 4),
                new Textbook("Математика 9 клас", 300, "Математика"),
                new Book("Гаррі Поттер і філософський камінь", 350, "Джоан Ролінґ"),
                new Magazine("Forbes", 120, 10)
            };

            Array.Sort(editions, (a, b) => a.Pages.CompareTo(b.Pages));

            Console.WriteLine("Відсортовані друковані видання за кількістю сторінок:");
            foreach (var edition in editions)
            {
                edition.Show();
            }
        }
        else
        {
            Console.WriteLine("Невірний вибір!");
        }
    }
}
