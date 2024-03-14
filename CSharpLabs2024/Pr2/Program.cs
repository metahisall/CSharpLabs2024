using System;

public class Class1
{

    static void Main()
    {



        /* Exercise 1


         Console.WriteLine("Введіть три числа:");
         int num1 = Convert.ToInt32(Console.ReadLine());
         int num2 = Convert.ToInt32(Console.ReadLine());
         int num3 = Convert.ToInt32(Console.ReadLine());

         if (num1 >= 1 && num1 <= 11)
         {
             Console.WriteLine($"{num1} належить інтервалу [1, 11]");

         }
         else
         {
             Console.WriteLine($"{num1} не належить інтервалу [1, 11]");
         }

         if (num2 >= 1 && num2 <= 11)
         {
             Console.WriteLine($"{num1} належить інтервалу [1, 11]");

         }
         else
         {
             Console.WriteLine($"{num2} не належить інтервалу [1, 11]");
         }

         if (num3 >= 1 && num3 <= 11)
         {
             Console.WriteLine($"{num3} належить інтервалу [1, 11]");

         }
         else
         {
             Console.WriteLine($"{num3} не належить інтервалу [1, 11]");
         } */







        /* Exercise 2


         Console.WriteLine("Введіть довжини сторін трикутника:");
        Console.Write("a = ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b = ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("c = ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (IsValidTriangle(a, b, c))
        {
            int perimeter = CalculatePerimeter(a, b, c);
            int area = CalculateArea(a, b, c);
            string triangleType = DetermineTriangleType(a, b, c);

            Console.WriteLine($"Периметр трикутника: {perimeter}");
            Console.WriteLine($"Площа трикутника: {area}");
            Console.WriteLine($"Тип трикутника: {triangleType}");
        }
        else
        {
            Console.WriteLine("Такий трикутник не існує. Будь ласка, введіть коректні значення сторін.");
        }
        }

        static bool IsValidTriangle(int a, int b, int c)
        {
        // Умова існування трикутника: сума будь-яких двох сторін має бути більшою за третю сторону
        return a + b > c && a + c > b && b + c > a;
        }

        static int CalculatePerimeter(int a, int b, int c)
        {
        return a + b + c;
        }

        static int CalculateArea(int a, int b, int c)
        {
        // Використовуємо формулу Герона для обчислення площі трикутника
        int s = (a + b + c) / 2;
        return (int)Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        static string DetermineTriangleType(int a, int b, int c)
        {
        if (a == b && b == c)
            return "рівносторонній";
        else if (a == b || a == c || b == c)
            return "рівнобедрений";
        else
            return "різносторонній"; */







        /* Exercise 3

        // Створення масиву X та введення його значень
        int[] X = new int[11];
        for (int i = 0; i < X.Length; i++)
        {
            Console.Write($"Введіть значення для X[{i}]: ");
            X[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Пошук мінімального та максимального значення в масиві X
        int min = X[0];
        int max = X[0];
        for (int i = 1; i < X.Length; i++)
        {
            if (X[i] < min)
                min = X[i];
            if (X[i] > max)
                max = X[i];
        }

        // Виведення масиву X та знайдених мінімального та максимального значень
        Console.WriteLine("Масив X:");
        foreach (int value in X)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
        Console.WriteLine($"Мінімальне значення: {min}");
        Console.WriteLine($"Максимальне значення: {max}"); */






        /* Exercise 4

        // Створення масиву Х
        int[] X = GenerateArray();
        Console.WriteLine("Масив X:");
        PrintArray(X);

        // Введення числа М
        Console.Write("Введіть число М: ");
        int M = Convert.ToInt32(Console.ReadLine());

        // Формування масиву Y
        int[] Y = FilterArray(X, M);

        // Виведення числа М та масивів Х та Y
        Console.WriteLine($"Число М: {M}");
        Console.WriteLine("Масив Y:");
        PrintArray(Y);
        }

        // Функція для створення масиву Х
        static int[] GenerateArray()
        {
        int[] X = new int[11];
        Random rand = new Random();
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = rand.Next(-10, 11); // Генеруємо випадкові числа в діапазоні від -10 до 10
        }
        return X;
        }

        // Функція для виведення масиву
        static void PrintArray(int[] array)
        {
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
        }

        // Функція для фільтрації масиву Х за значенням М
        static int[] FilterArray(int[] X, int M)
        {
        int count = 0;
        foreach (int value in X)
        {
            if (Math.Abs(value) > M) // Перевірка на відповідність за умовою
            {
                count++;
            }
        }

        int[] Y = new int[count];
        int index = 0;
        foreach (int value in X)
        {
            if (Math.Abs(value) > M) // Перевірка на відповідність за умовою
            {
                Y[index] = value;
                index++;
            }
        }

        return Y; */
    }
}