using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_app.UI
{
    public static class Utility
    {
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine($"Enter {prompt}");
            return Console.ReadLine();
        }
public static void PressEnterToContinue() 
{
            Console.WriteLine("\n\nPress enter to continue...");
            Console.ReadLine();
}
    }
}