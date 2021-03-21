using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject.EventSubscriber
{
    public class UserInput
    {
        List<double> userEntries = new List<double>();

        public void History()
        {
            Console.WriteLine("Displaying history...");
            Console.WriteLine(userEntries);
        }

    }
}
