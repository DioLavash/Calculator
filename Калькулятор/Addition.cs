namespace EngineeringCalculator {
    class Addition : Operation {
        public override double Execute(double[] num1) => num1.Sum();
    }
}