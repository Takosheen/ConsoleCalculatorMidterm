using System;
using System.Collections.Generic;
using System.Text;
using ConsoleCalculatorMidterm;
using CalculatorProject;
using ConsoleCalculatorMidterm.ConsoleEventHandler;
using CalculatorProject.CalculatorFunctions;
using CalculatorProject.EventSubscriber;



namespace ConsoleCalculatorMidterm
{
    public class InputAction
    {
        Calculator _calculator = new Calculator();
        EventPublisher _eventPub = new EventPublisher();
        double _inputOne;
        double _inputTwo;
        string _operation;
        public void Calculator()
        {
            Console.WriteLine("Please choose an operation(+,-,/,*,>/ for square root, ^2 for squaring the number), or view the history of calculations with 'H'");
            string _operation = Console.ReadLine();
            this._operation = _operation;
            StoreInput();
            Calculation();//will take the Func
        }

        void StoreInput() //store input into EventSub.UserInput?
        {
            try
            {
                Console.WriteLine("Please enter two numbers, one at a time:");
                this._inputOne = Double.Parse(Console.ReadLine());
                // store inputs here, and confirm when they are stored.
                Console.WriteLine(_inputOne); // remove when done

                Console.WriteLine("Inputs received");
                this._inputTwo = Double.Parse(Console.ReadLine());
                // store inputs here, and confirm when they are stored.
                Console.WriteLine("Inputs received");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid value entered in for either input, please enter a number.");
                Console.WriteLine(e.Message);
            }
        }
        void StoreResult()
        {

        }
      /*  void OnUserInput(string _operation)
        {
            string _op = _operation;

        }*/
        public Func<double, double, double> Calculation()
        {
            Console.WriteLine(_inputOne);

            Func<double, double, double> _input = Operations.Unassigned;
            switch (_operation)
            {
                case "+":
                    _input = Operations.Sum;
                    Console.WriteLine(_input);
                    return _input;
                case "-":
                   _input = Operations.Difference;
                    Console.WriteLine(_input);
                    return _input;
                case "/":
                    _input = Operations.Division;
                    Console.WriteLine(_input);
                    return _input;
                case "*":
                     _input = Operations.Multiplication;
                    Console.WriteLine(_input);
                    return _input;
                case ">/":
                     _input = Operations.Sqrt;
                    Console.WriteLine(_input);
                    return _input;
                case "^2":
                     _input = Operations.Squared;
                    Console.WriteLine(_input);
                    return _input;
               /*case "H":
                */
                default:
                    Console.WriteLine("No operation.");
                    return _input = Operations.Unassigned;

            }

        }
    }
}
