using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 

namespace HW_Tamagochi
{
    public class TamagochiPicture
    {
        public static void ShowPic()
        {
            Console.SetWindowSize(54, 17);
            bool eyeMove = true;
            while (true)
            {

                if (eyeMove)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("\n\t|_|_|_|_");
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
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("\n\t|_|_|_|_");
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

                System.Threading.Thread.Sleep(800);
                Console.Clear();
            }
        }
    }
}
