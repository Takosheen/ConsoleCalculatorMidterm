using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.Interfaces;


namespace CalculatorProject.Models
{
    public class BulkCalculations
    {
            public ListOfCalculations _calculations = new ListOfCalculations();


            public IBulkOp CreateCalculation(double a, double b, Func<double, double, double> _operation)
            {

                var _calculation = Calculation.Create(a, b, _operation);
            return null;
                /*_calculations.AddCalculation(_calculation);
                return _calculation;*/
            }

            public IBulkOp CreateCalculation(List<double> listOfValues, Func<List<double>, double> _operation)
            {
            return null;
               /* var _calculation = ListCalculations.Create(listOfValues, _operation);
                _calculations.AddCalculation(_calculation);
                return _calculation;*/
            }
            public List<IBulkOp> GetList()
            {
                var listResult = _calculations.Calculations;
                return listResult;
            }


        }
    }



