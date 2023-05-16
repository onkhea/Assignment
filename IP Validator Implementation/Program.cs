using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Validator_Implementation
{

    public class Program
    {
        public static void Mains(string[] args)
        {
            // Create two instances of the console application class.
            var consoleApp1 = new LeadingZeros();
            var consoleApp2 = new OutputSingleString();
            var consoleApp3 = new ConsoleApp();

            // Call the "Run" method on each instance of the console application class to launch the console application.
            //Answer 1
            //Console.WriteLine(consoleApp1);
            //Answer 2
            Console.WriteLine(consoleApp2);
            //Answer 3
            // Console.WriteLine(consoleApp3);

            //OutPut 
            //  Enter an IP address:
            //192.168.1.1
            //The IP address is valid.

            //Enter an IP address:
            //01.02.03.04
            //The IP address is invalid.
        }
    }

}
