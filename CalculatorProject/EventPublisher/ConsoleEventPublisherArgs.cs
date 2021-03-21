using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject.EventPublisher
{
    public class ConsoleEventPublisherArgs : EventArgs
    {
        public double UserInput { get; set; }
        public Func<double,double,double> Operation { get; set; }
    }
}
