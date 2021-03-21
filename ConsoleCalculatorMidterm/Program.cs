using System;
using ConsoleCalculatorMidterm.ConsoleEventHandler;

namespace ConsoleCalculatorMidterm
{
    class Program
    {
        static void Main(string[] args)
        {
            InputAction action = new InputAction();
            EventPublisher actionEvent = new EventPublisher();
            string end = "";
            while(end != "end")
            {
                action.Calculator();
                end = Console.ReadLine();
            }
            

            //Func<double, double, double> _event = action.Calculation();
        }
    }
}
