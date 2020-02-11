using System;

namespace TipCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      // welcome user
      Console.WriteLine("Welcome User!");
      //ask for bill total and run error correction
      Console.WriteLine("How much was your meal?");
      var billSansTip = Console.ReadLine();
      //ask how service
      Console.WriteLine("How was your service?");
      Console.WriteLine("Valid choices are okay, good, and great.");
      var service = Console.ReadLine();
      //ok, good, great, default 
      //calculate tip based on service
      var tipPercentage = 0.15;
      if (service == "okay")
      {
        tipPercentage = 0.18;
      }
      else if (service == "good")
      {
        tipPercentage = 0.20;
      }
      else if (service == "great")
      {
        tipPercentage = 0.25;
      }
      else
      {
        tipPercentage = 0.15;
      }
      var tip = double.Parse(billSansTip) * tipPercentage;
      var total = double.Parse(billSansTip) + tip;
      //multiply tip percent by 100
      var TipToDisplay = tipPercentage * 100;
      //display the result
      Console.WriteLine("Your bill was $" + billSansTip + ".");
      Console.WriteLine(TipToDisplay + "% tip would be $" + tip + ".");
      Console.WriteLine("Your total will be $" + total + ".");

    }
  }
}
