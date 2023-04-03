using System;
using System.Threading;
using System.Windows.Forms;
using static System.Console;
using System.Timers;
using System.Linq;

namespace HW_Tamagochi
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            RequestAll.RequestRead(); 
            Screen1.ScreenLogo();
            StartStop.Start(true);
            
        }
    }
}
//-cure after 3 times not respond+
//-living for 2 minutes+; 
//-unique requests from array+; 
//-timer for scores+
//-winBox against pic+
//-start game+
//-list of requests read from file
//-resultTab
//-XLM file











