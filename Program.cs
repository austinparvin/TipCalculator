using System;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcome the User
            Console.WriteLine("\nWelcome User!!!\n");
            // ask how much the bill 
            Console.WriteLine("How much was your meal?\n");
            var total = Console.ReadLine();
            // check if the input was a number
            double billTotal;
            var isValid = Double.TryParse(total, out billTotal);
            if (!isValid)
            {
                Console.WriteLine("\nThat is not a number, try again\n");
                total = Console.ReadLine();
                billTotal = Double.Parse(total);
            }


            // how was the service?
            Console.WriteLine("\nHow was your service okay, good, or great?\n");
            var serviceExperience = Console.ReadLine().ToLower();
            //okay, good, great, default



            // calculate tip based on the level of service
            var tipPercentage = 0.15;
            if (serviceExperience == "okay")
            {
                tipPercentage = 0.18;
            }
            else if (serviceExperience == "good")
            {
                tipPercentage = 0.20;
            }
            else if (serviceExperience == "great")
            {
                tipPercentage = 0.25;
            }


            var tip = Double.Parse(total) * tipPercentage;
            //Convert.ToDouble will accept any type Double.Parse only takes a string
            // add tip to the total
            var grandTotal = Double.Parse(total) + tip;
            // display the result
            Console.WriteLine("\nYour total was " + total);
            Console.WriteLine("The {0}% tip is {1}", tipPercentage * 100, Math.Round(tip, 2));
            Console.WriteLine("Grandtotal is " + Math.Round(grandTotal, 2) + "\n");

        }
    }
}
