using System;

namespace TipCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      // welcome user
      Console.WriteLine("Welcome User!");
      //ask for bill total
      Console.WriteLine("How much was your meal?");
      var billSansTip = Console.ReadLine();
      //calculate 18%
      var tip = double.Parse(billSansTip) * 0.18;
      var total = double.Parse(billSansTip) + tip;
      //display the result
      Console.WriteLine("Your bill was $" + billSansTip + ".");
      Console.WriteLine("An 18% tip would be $" + tip + ".");
      Console.WriteLine("Your total will be $" + total + ".");

    }
  }
}
