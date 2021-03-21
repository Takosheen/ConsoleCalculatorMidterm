using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorProject.CalculatorFunctions
{
    public class ListOp
    {
        public static Func<List<double>, double> SumList = (a) => a.Sum();
        public static Func<List<double>, double> Unassigned = (a) => 0;
    }
}
