using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCalculator {
        public abstract class Operations {
            public abstract double Run(double[] numbers);
        }
        public class CosOperations : Operations {
            public override double Run(double[] numbers) {
                Console.Write("Введите количество градусов: ");
                double angle = Convert.ToDouble(Console.ReadLine());
                return Math.Cos(numbers[0]);
            }
        }
    }
