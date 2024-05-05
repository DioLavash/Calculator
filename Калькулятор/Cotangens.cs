using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCalculator {
    class Cotangens : Operation {
        public override double Execute(double[] num1) => 1 / Math.Tan(num1[0]);
    }
}
