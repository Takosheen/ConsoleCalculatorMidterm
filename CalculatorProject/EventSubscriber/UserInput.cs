using CalculatorProject.Interfaces;
using CalculatorProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject.EventSubscriber
{
    public class UserInput
    {
        List<double> userEntries = new List<double>();
        Calculator _calculator = new Calculator();
        public void History()
        {
            Console.WriteLine("Displaying history...");
            Console.WriteLine(userEntries);
        }
        public IBulkOp PerformCalc(double a, double b, Func<double, double, double> operation)
        {
            var _result = _calculator.SoloCalc(a, b, operation);
            return _result;
        }
    }
}
