using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCalculator {
    class Pow : Operation {
        public override double Execute(double[] num1) => num1[0] * num1[0];
    }
}
