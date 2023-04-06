using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using static System.Console;
using System.Timers;
using System.Diagnostics; 

namespace HW_Tamagochi
{
    public class TamagochiPicture
    {
        public static bool gaming=true;
        
        public static bool curePic; 
        public static void ShowPicTimer(Object source, ElapsedEventArgs e)
        {
            if (gaming) gaming=false;
        }
        public static void ShowPic()
        {
            Console.SetWindowSize(54, 17);
            bool eyeMove = true;
            
            while (gaming==true)
            {
                if (eyeMove)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(8, 0);
                    WriteLine("|_|_|_|_");
                    WriteLine("\t/       \\");
                    Write("\t|  ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Write((char)164 + "  " + (char)164);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    WriteLine(" |"); 
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("\t|    |  |");
                    WriteLine("\t|   ___ |");
                    WriteLine("\t|       |");
                    WriteLine("\t|_______|");
                    if (curePic == true)
                    {
                        eyeMove = true; StartStop.scoreCount.Stop(); 
                    }
                    else
                    {
                        eyeMove = false;StartStop.scoreCount.Start(); 
                    }

                }
                else
                {
                    Console.SetCursorPosition(8, 0);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("|_|_|_|_");
                    WriteLine("\t/       \\");
                    Write("\t|   ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Write((char)164 + "  " + (char)164);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("|"); 
                    WriteLine("\t|    |  |");
                    WriteLine("\t|   ___ |");
                    WriteLine("\t|   \\_/ |");
                    WriteLine("\t|_______|");
                    eyeMove = true;
                }
                System.Threading.Thread.Sleep(600);
            }
             
            //WriteLine(score); 
        }
    }
}
