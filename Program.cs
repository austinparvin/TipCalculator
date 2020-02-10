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
      // calculate 18%
      var tip = Double.Parse(total) * 0.18;
      //Convert.ToDouble will accept any type Double.Parse only takes a string
      // add tip to the total
      var grandTotal = Double.Parse(total) + tip;
      // display the result
      Console.WriteLine("Your total was " + total);
      Console.WriteLine("The 18% tip is " + total);
      Console.WriteLine("Grandtotal is " + grandTotal);
    }
  }
}
