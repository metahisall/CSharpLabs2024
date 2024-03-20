/* EXERCISE 1
using System;

public class Book
{
    private Title title;
    private Author author;
    private Content content;

    public Book(string title, string authorName, string content)
    {
        this.title = new Title(title);
        this.author = new Author(authorName);
        this.content = new Content(content);
    }

    public void SetAuthor(string authorName)
    {
        author.SetAuthor(authorName);
    }

    public void SetContent(string content)
    {
        this.content.SetContent(content);
    }

    public void Show()
    {
        title.Show();
        author.Show();
        content.Show();
    }
}

public class Title
{
    private string title;

    public Title(string title)
    {
        this.title = title;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Title: " + title);
        Console.ResetColor();
    }
}

public class Author
{
    private string authorName;

    public Author(string authorName)
    {
        this.authorName = authorName;
    }

    public void SetAuthor(string authorName)
    {
        this.authorName = authorName;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Author: " + authorName);
        Console.ResetColor();
    }
}

public class Content
{
    private string content;

    public Content(string content)
    {
        this.content = content;
    }

    public void SetContent(string content)
    {
        this.content = content;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Content: " + content);
        Console.ResetColor();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book myBook = new Book("1984", "George Orwell", "Thematically, the novel deals with the consequences of totalitarianism, mass surveillance and brainwashing of people in a totalitarian society. Orwell, a democratic socialist, created a totalitarian state in the novel modeled on the Stalinist USSR and Nazi Germany.");
        myBook.Show();

        Console.WriteLine("\nChanging author...");
        myBook.SetAuthor("Haruki Murakami");
        myBook.Show();

        Console.WriteLine("\nChanging content...");
        myBook.SetContent("“1Q84” is a book about the search for psychological support in the world of different landmarks. The main characters of the book are the girl-instructor of the fitness club Aomame and the mathematics teacher Tengo.");
        myBook.Show();
    }
} */





/* EXERCISE 2
using System;

public class Point
{
    private int x;
    private int y;
    private string name;

    public int X { get { return x; } }
    public int Y { get { return y; } }
    public string Name { get { return name; } }

    public Point(int x, int y, string name)
    {
        this.x = x;
        this.y = y;
        this.name = name;
    }
}

public class Figure
{
    private Point[] points;

    public Figure(params Point[] points)
    {
        if (points.Length < 3 || points.Length > 5)
        {
            throw new ArgumentException("A figure must have 3 to 5 points.");
        }

        this.points = new Point[points.Length];

        for (int i = 0; i < points.Length; i++)
        {
            this.points[i] = points[i];
        }
    }

    private double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void PerimeterCalculator()
    {
        double perimeter = 0;

        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += LengthSide(points[i], points[i + 1]);
        }

        perimeter += LengthSide(points[points.Length - 1], points[0]);

        Console.WriteLine("Периметр фігури: " + perimeter);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point A = new Point(0, 0, "A");
        Point B = new Point(0, 4, "B");
        Point C = new Point(3, 0, "C");
        Point D = new Point(3, 4, "D");

        Figure figure = new Figure(A, B, C, D);

        figure.PerimeterCalculator();
    }
}
*/
