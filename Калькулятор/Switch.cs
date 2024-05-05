using EngineeringCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCalculator {
    public class Switch {
        public void ChoiceOperation(int choice) {
            Result result = new Result();
            EnterNumbers enterNumbers = new EnterNumbers();
            switch (choice) {
                case 1:
                    Addition addition = new Addition();
                    result.Resultat(addition.Execute(enterNumbers.Numbers()));
                    break;
                case 2:
                    Subtraction substruction = new Subtraction();
                    result.Resultat(substruction.Execute(enterNumbers.Numbers()));
                    break;
                case 3:
                    Multiplication multiplication = new Multiplication();
                    result.Resultat(multiplication.Execute(enterNumbers.Numbers()));
                    break;
                case 4:
                    Division division = new Division();
                    result.Resultat(division.Execute(enterNumbers.Numbers()));
                    break;
                case 5:
                    Sine sine = new Sine();
                    result.Resultat(sine.Execute(enterNumbers.Numbers()));
                    break;
                case 6:
                    Cosine cosine = new Cosine();
                    result.Resultat(cosine.Execute(enterNumbers.Numbers()));
                    break;
                case 7:
                    Tangens tangens = new Tangens();
                    result.Resultat(tangens.Execute(enterNumbers.Numbers()));
                    break;
                case 8:
                    Cotangens cotangens = new Cotangens();
                    result.Resultat(cotangens.Execute(enterNumbers.Numbers()));
                    break;
                case 9:
                    Pow pow = new Pow();
                    result.Resultat(pow.Execute(enterNumbers.Numbers()));
                    break;
                case 10:
                    Sqrt sqrt = new Sqrt();
                    result.Resultat(sqrt.Execute(enterNumbers.Numbers()));
                    break;
                case 11:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
        }
    }
}
