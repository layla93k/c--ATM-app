using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_app.UI
{
    public static class AppScreen
    {
internal static void Welcome()
{
      //clear the console screen
            Console.Clear();
            Console.Title = "Layla's ATM App";
            Console.ForegroundColor = ConsoleColor.White;
            //set the welcome message
            Console.WriteLine("--------------------Welcome to my ATM App--------------------");
            //prompt user to enter card
            Console.WriteLine("Please enter your ATM card");
            Console.WriteLine("(A real ATM machine will read and validate your card number. Please do not put your real card number in!)");
           Utility.PressEnterToContinue();
}

    }
}