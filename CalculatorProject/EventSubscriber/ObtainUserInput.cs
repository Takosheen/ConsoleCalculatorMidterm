using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.EventPublisher;

namespace CalculatorProject.EventSubscriber
{
    public class ObtainUserInput
    {
        public void ObtainResult(object e, ConsoleEventPublisherArgs Event)
        {
            Console.WriteLine("Result: "+ Event.Result.GetResult());
        }
    }
}
