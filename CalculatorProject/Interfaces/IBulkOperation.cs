using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject.Interfaces
{
    public interface IBulkOperation
    {
        public IBulkOp Create(double a, double b, Func<double, double, double> _operation);
        /*{
            Calculator _calculator = new Calculator();
            //IBulkOperation _calculator;
            return (IBulkOp)_calculator;
        }*/
        public IBulkOp Create(List<double> listOfValues, Func<List<double>, double> operation);
    }
}
