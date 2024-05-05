namespace EngineeringCalculator {
    class CalculatorMenu {
        public void ShowMenu() {
            Console.WriteLine("Добро пожаловать в Казахстан");
            while (true) {
                Console.Clear();
                Console.WriteLine("Главное меню:");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Деление");
                Console.WriteLine("5. Синус");
                Console.WriteLine("6. Косинус");
                Console.WriteLine("7. Тангенс");
                Console.WriteLine("8. Котангенс");
                Console.WriteLine("9. Квадрат числа");
                Console.WriteLine("10. Корень числа");
                Console.WriteLine("11. Выйти");
                Console.Write("Выберите действие: ");
                int choice = Convert.ToInt32 (Console.ReadLine());
                Switch newswitch = new Switch();
                newswitch.ChoiceOperation(choice);
            }
        }
        void PressToContinue() {
            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}