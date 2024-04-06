using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Главное меню:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Выйти");
            Console.Write("Выберите действие: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    PerformOperation("+");
                    break;
                case "2":
                    PerformOperation("-");
                    break;
                case "3":
                    PerformOperation("*");
                    break;
                case "4":
                    PerformOperation("/");
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
        }
    }
    static void PerformOperation(string op)
    {
        Console.WriteLine($"Введите первое число {op}: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Введите второе число {op}: ");
        double num2 = double.Parse(Console.ReadLine());

        try
        {
            double result = Calculate(num1, num2, op);
            Console.WriteLine($"Результат: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
    static double Calculate(double num1, double num2, string op)
    {
        switch (op)
        {
            case "+":
                return num1 + num2;
            case "-":
                return num1 - num2;
            case "*":
                return num1 * num2;
            case "/":
                if (num2 == 0)
                {
                    throw new DivideByZeroException("Деление на ноль.");
                }
                return num1 / num2;
            default:
                throw new ArgumentException("Неверная операция.");
        }
    }
}
