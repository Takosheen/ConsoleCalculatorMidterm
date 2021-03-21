using CalculatorProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject.Models
{
    class ListCalculations : IBulkOp
    {

        public Func<List<double>, double> BulkOperation { get; set; }
        public List<double> ListOfValues { get; set; }

        public static ListCalculations Create(List<double> listOfValues, Func<List<double>, double> operation)
        {
            var _calculation = new ListCalculations(listOfValues, operation);
            return _calculation;
        }
        public ListCalculations(List<double> listOfValues, Func<List<double>, double> calculation)
        {
            ListOfValues = listOfValues;
            BulkOperation = calculation;
        }
        public double GetResult()
        {
            return BulkOperation(ListOfValues);
        }
    

    }
}
