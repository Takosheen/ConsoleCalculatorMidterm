using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject.EventPublisher
{
    public class ConsoleEventPublisher
    {
        public event EventHandler<ConsoleEventPublisherArgs> Input;
        Calculator _calculator = new Calculator();
        public void TakeUserInput(double userInput)
        {
            try
            {
                Input(this, new ConsoleEventPublisherArgs() { UserInput = userInput });
            }
            catch(Exception e)
            {
                Console.WriteLine("User input invalid. Please enter a valid number.");
            }
        }
        public void TakeOperation(Func<double,double,double> operation)
        {
            try
            {
                Input.Invoke(this, new ConsoleEventPublisherArgs() { Operation = operation });
            }
            catch(Exception e)
            {
                Console.WriteLine("Operation invalid. Enter a valid operation.");
            }
        }

    }
}
