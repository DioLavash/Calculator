using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCalculator {
    public class EnterNumbers {
        public double[] Numbers() {
            var numbers = new List<double>();
            Console.Write("Введите числа: ");
            string input = Console.ReadLine();
            string[] newinput = input.Split(' ');
            foreach (var number in newinput) {
                numbers.Add(Convert.ToDouble(number));
            }
            return numbers.ToArray();
        }
    }
}
