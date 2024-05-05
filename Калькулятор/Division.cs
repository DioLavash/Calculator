namespace EngineeringCalculator {
    class Division : Operation {
        public override double Execute(double[] num1) {
            if (num1[0] == 0)
                throw new DivideByZeroException("Деление на ноль невозможно.");
            return num1[1];
        }
    }
}