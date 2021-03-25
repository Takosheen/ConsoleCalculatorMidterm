using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.Interfaces;

namespace CalculatorProject.EventPublisher
{
    public class ConsoleEventPublisherArgs : EventArgs
    {
        public double UserInput { get; set; }
        public Func<double,double,double> Operation { get; set; }
        public IBulkOp Result { get; set; }
    }
}
