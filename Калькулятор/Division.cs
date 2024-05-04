namespace EngineeringCalculator
{
    class Division : Operation
    {
        public override double Execute(double num1, double num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException("Деление на ноль невозможно.");
            return num1 / num2;
        }
    }
}