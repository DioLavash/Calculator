namespace EngineeringCalculator {
    class Cosine : Operation {
        public override double Execute(double[] num1) => Math.Cos(num1[0]);
    }
}