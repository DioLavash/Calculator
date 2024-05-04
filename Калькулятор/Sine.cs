namespace EngineeringCalculator
{
    class Sine : Operation
    {
        public override double Execute(double num1, double num2) => Math.Sin(num1);
    }
}