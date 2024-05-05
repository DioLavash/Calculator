using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCalculator {
    class Sqrt : Operation {
        public override double Execute(double[] num1) => Math.Sqrt(num1[0]);
    }
}

