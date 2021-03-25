using CalculatorProject;
using CalculatorProject.CalculatorFunctions;
using CalculatorProject.EventSubscriber;
using CalculatorProject.Interfaces;
using CalculatorProject.Models;
using ConsoleCalculatorMidterm.ConsoleEventHandler;
using System;

namespace ConsoleCalculatorMidterm
{
    public class InputAction
    {
        Calculator _calculator = new Calculator();
        EventPublisher _eventPub = new EventPublisher();
        Calculation _calculation = new Calculation();
        InputAction _event = new InputAction();
        UserInput input = new UserInput();
        
        double _inputOne;
        double _inputTwo;
        string _operation;

        public void Calculator()
        {
            Console.WriteLine("Please choose an operation(+,-,/,*,>/ for square root, ^2 for squaring the number), or view the history of calculations with 'H'");
            string _operation = Console.ReadLine();
            this._operation = _operation;
            StoreInput();
          
            
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
                Calculate();
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid value entered in for either input, please enter a number.");
                Console.WriteLine(e.Message);
            }
        }
        void ObtainResult()
        {
            var calc = new ObtainUserInput();
            _calculator._eventPub.Input += calc.ObtainResult;

        }
        void StoreResult()
        {

        }
        /*  void OnUserInput(string _operation)
          {
              string _op = _operation;

          }*/
        public IBulkOp Calculate()
        {
            Console.WriteLine("this is input 2 in Calculation" + _inputTwo); // remove when finished.

            Func<double, double, double> _input = Operations.Sum;

            switch (_operation)
            {
             //outsource input as well
             //outsource the operations part to get it from somewhere else, i.e. calculations.
            //Console.WriteLine("Calculation started.");
            case "+":
                  
                Console.WriteLine(_input);
                //return _input;
                var _resulting = input.PerformCalc(_inputOne, _inputTwo, _input);
                    var _create = Calculation.Create(_inputOne, _inputTwo, _input);
                Console.WriteLine("this is resulting" + _resulting);
                    Console.WriteLine(_create);
            //var _result = _calculator.SoloCalc(_inputOne, _inputTwo, _input);
                return _create; 
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


