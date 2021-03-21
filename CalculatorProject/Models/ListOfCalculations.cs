using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.Interfaces;

namespace CalculatorProject.Models
{
    public class ListOfCalculations
    {
        public List<IBulkOp> Calculations = new List<IBulkOp>();

        public void AddCalculation(IBulkOp calculations)
        {
            Calculations.Add(calculations);
        }
    }
}
