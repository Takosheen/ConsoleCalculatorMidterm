using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject.Models
{
    public class Calculation
    {
        //store 1 value
        public double A { get; set; }
        //store 1 value
        public double B { get; set; }
        //store a single operation function
        public Func<double, double, double> Operation { get; set; }
        public Calculation(double a, double b, Func<double, double, double> calculation)
        {
            A = a;
            B = b;
            Operation = calculation;
        }
        public static Calculation Create(double a, double b, Func<double, double, double> calculation)
        {
            var _calculation = new Calculation(a, b, calculation);
            return _calculation;
        }


        public double GetResult()
        {
            return Operation(A, B);

        }

        /* public double validate(){
                if (BulkOperation != null)
                {
                    return BulkOperation(ListOfValues);
                }
                else
                {
                    return Operation(A, B);
                }

            }*/


    }
}
