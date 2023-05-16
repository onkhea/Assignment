using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Validator_Implementation
{
    public class LeadingZeros
    {
        public static void Mains(string[] args)
        {
            // Get the input IP address from the user.
            Console.WriteLine("Enter an IP address:");
            string ipAddress = Console.ReadLine();

            // Split the IP address into four octets.
            string[] octets = ipAddress.Split('.');

            // Check that each octet is a valid number between 0 and 255, and does not start with a zero.
            bool isValid = true;
            for (int i = 0; i < octets.Length; i++)
            {
                int value;
                if (!int.TryParse(octets[i], out value) || value < 0 || value > 255 || octets[i].StartsWith("0"))
                {
                    isValid = false;
                    break;
                }


                // Print the result to the console.
                if (isValid)
                {
                    Console.WriteLine("The IP address is valid.");
                }
                else
                {
                    Console.WriteLine("The IP address is invalid.");
                }
            }
        }

 
    }
}

