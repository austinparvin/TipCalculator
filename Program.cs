using System;

namespace TipCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      // welcome the User
      Console.WriteLine("Welcome User!!!");
      // ask how much the bill 
      Console.WriteLine("How much was your meal?");
      var total = Console.ReadLine();
      // how was the service
      Console.WriteLine("How was your service okay, good, or great?");
      var serviceExperience = Console.ReadLine();
      //okay, good, great, default



      // calculate tip based on the level of service
      var tipPercentage = 0.15;
      if (serviceExperience == "okay") {
        tipPercentage = 0.18;
      }
      else if (serviceExperience == "good") {
        tipPercentage = 0.20;
      }
      else if (serviceExperience == "great") {
        tipPercentage = 0.25;
      }


      var tip = Double.Parse(total) * tipPercentage;
      //Convert.ToDouble will accept any type Double.Parse only takes a string
      // add tip to the total
      var grandTotal = Double.Parse(total) + tip;
      // display the result
      Console.WriteLine("Your total was " + total);
      Console.WriteLine("The {0}% tip is {1}",tipPercentage*100,total);
      Console.WriteLine("Grandtotal is " + grandTotal);

    }
  }
}
