using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 

namespace HW_Tamagochi
{
    internal class StartStop
    {
        public static bool _startGame {  get; set; }
        public static bool _stopGame { get; set;}

        public static bool Start()
        {
            ReadKey(); 
            WriteLine("Timer is ON"); 
            //TamagochiPicture.gaming = true;
            return _startGame=true;
        }
        public static bool Stop()
        {
            ReadKey();
            //TamagochiPicture.gaming = false;
            WriteLine($"The game result is {Score._score}"); 
            return _stopGame = true;
        }
    }
}
