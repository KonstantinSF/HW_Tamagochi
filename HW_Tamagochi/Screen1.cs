using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console; 

namespace HW_Tamagochi
{
    internal class Screen1
    {
        public static void ScreenLogo()
        {
            ForegroundColor = ConsoleColor.Green;
            CursorSize = 1;
            SetCursorPosition(10, 5);
            WriteLine("* * *  THAMAGOCHI  * * *");
            SetCursorPosition(0, 11);
            WriteLine("Drawing: Firulev Konstantin");
            WriteLine("Developed by Firulev Konstantin");
            WriteLine("\t\tVologda, 2023");
            CursorSize = 1; WriteLine("Press any key to continue . . .");
            ReadKey(); 
            Clear();
        }
    }
}
