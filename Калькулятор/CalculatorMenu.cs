namespace EngineeringCalculator
{
    class CalculatorMenu
    {
        private readonly Calculator calculator = new Calculator();
        public void ShowMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Главное меню:");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Деление");
                Console.WriteLine("5. Синус");
                Console.WriteLine("6. Косинус");
                Console.WriteLine("7. Выйти");
                Console.Write("Выберите действие: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        PerformOperation(new Addition());
                        break;
                    case "2":
                        PerformOperation(new Subtraction());
                        break;
                    case "3":
                        PerformOperation(new Multiplication());
                        break;
                    case "4":
                        PerformOperation(new Division());
                        break;
                    case "5":
                        PerformOperation(new Sine());
                        break;
                    case "6":
                        PerformOperation(new Cosine());
                        break;
                    case "7":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
        }
        void PerformOperation(Operation operation)
        {
            Console.WriteLine("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double num2 = double.Parse(Console.ReadLine());
            try
            {
                double result = calculator.Calculate(num1, num2, operation);
                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            PressToContinue();
        }

        void PressToContinue()
        {
            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}