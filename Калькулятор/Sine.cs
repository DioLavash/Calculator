namespace EngineeringCalculator {
    class Sine : Operation {
        public override double Execute(double[] num1) => Math.Sin(num1[0]);
    }
}