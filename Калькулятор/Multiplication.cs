namespace EngineeringCalculator {
    class Multiplication : Operation {
        public override double Execute(double[] num1) => num1[0] * num1[1];
    }
}