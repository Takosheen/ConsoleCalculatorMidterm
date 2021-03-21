using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.EventPublisher;
using CalculatorProject.EventSubscriber;

namespace ConsoleCalculatorMidterm.ConsoleEventHandler
{
    public class EventPublisher
    {
        public ConsoleEventPublisher _event = new ConsoleEventPublisher();
        public UserInput _inputs = new UserInput();

        void History()
        {
            //_event.Input += _inputs.History;
        }

    }
}
