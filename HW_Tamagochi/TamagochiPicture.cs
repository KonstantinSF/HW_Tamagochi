using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using static System.Console; 

namespace HW_Tamagochi
{
    public class TamagochiPicture
    {
        public static bool _gameOn=true; 
        public static void ShowPic()
        {
        
            Console.SetWindowSize(54, 17);
            bool eyeMove = true;
            while (_gameOn==true)
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
                    WriteLine(" |"); eyeMove = false;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("\t|    |  |");
                    WriteLine("\t|   ___ |");
                    WriteLine("\t|       |");
                    WriteLine("\t|_______|");
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
                    WriteLine("|"); eyeMove = true;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("\t|    |  |");
                    WriteLine("\t|   ___ |");
                    WriteLine("\t|   \\_/ |");
                    WriteLine("\t|_______|");
                }
                System.Threading.Thread.Sleep(600);
                //Console.Clear();
            }
        }
    }
}
