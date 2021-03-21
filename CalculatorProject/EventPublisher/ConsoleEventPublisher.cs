using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject.EventPublisher
{
    public class ConsoleEventPublisher
    {
        public event EventHandler<ConsoleEventPublisherArgs> Input;
        public void TakeUserInput(double userInput)
        {
            if(Input != null)
            {
                Input(this, new ConsoleEventPublisherArgs() { UserInput = userInput });
            }
        }
        public void TakeOperation(Func<double,double,double> operation)
        {
            if(operation != null)
            {
                Input.Invoke(this, new ConsoleEventPublisherArgs() { Operation = operation });
            }
        }
    }
}
