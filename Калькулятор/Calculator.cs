namespace EngineeringCalculator
{
    class Calculator
    {
        public double Calculate(double num1, double num2, Operation operation)
        {
            return operation.Execute(num1, num2);
        }
    }
}