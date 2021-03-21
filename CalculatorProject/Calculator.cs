using System;
using System.Collections.Generic;
using CalculatorProject.Interfaces;
using CalculatorProject.Models;

namespace CalculatorProject
{
    public class Calculator
    {
        BulkCalculations _bulkCalculations = new BulkCalculations();
        private Calculation calculation;
        private BulkCalculations bulkCalculations;

        // Calculator Listofvalues = new Calculator();
        private IBulkOperation _calculator { get; set; }
      //  public event EventHandler<GreaterThanTenArgs> OnGreaterThanten;
        public Calculator()
        {
        }
        public Calculator(IBulkOperation calculator)
        {
            this._calculator = calculator;
        }

        public Calculator(Calculation calculation)
        {
            this.calculation = calculation;
        }

       /* public Calculator(BulkCalculations bulkCalculations)
        {
            this.bulkCalculations = bulkCalculations;
        }*/

        public IBulkOp SoloCalc(double a, double b, Func<double, double, double> _operation)
        {
            return _calculator.Create(a, b, _operation);
        }
        public IBulkOp ListCalc(List<double> listOfValues, Func<List<double>, double> _operation)
        {

            return _calculator.Create(listOfValues, _operation);

        }
    }
}
