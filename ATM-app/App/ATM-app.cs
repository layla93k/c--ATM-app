using System;
using ATM_app.UI;

namespace ATMApp
{
    class ATMApp
    {
        static void Main(string [] args)
        {
          AppScreen.Welcome();
          string cardNum = Utility.GetUserInput("your card number");
          Console.WriteLine($"Your card number is {cardNum}");

          Utility.PressEnterToContinue();

        }
    }
}