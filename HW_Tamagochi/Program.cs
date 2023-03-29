using System;
using System.Threading;
using System.Windows.Forms;
using static System.Console;
using System.Timers; 



namespace HW_Tamagochi
{
    internal class Program
    {
        public static void SetTimer()
        {
            Boxtimer = new System.Timers.Timer(2500);
            Boxtimer.Elapsed += GetWindowsDialog.buttonClick; 
            Boxtimer.AutoReset = true;
            Boxtimer.Enabled = true;
        }

        bool _gameon = true;
        public static System.Timers.Timer Boxtimer;
        public static void Main(string[] args)
        {
            Thread showPic = new Thread(new ThreadStart(TamagochiPicture.ShowPic));
            showPic.Priority = ThreadPriority.BelowNormal;
            showPic.Start();
            //Thread buttonCilck = new Thread (new ThreadStart(GetWindowsDialog.buttonClick));
            SetTimer(); 
            if (TamagochiPicture._gameOn == false)
            {
                showPic.Abort();
            }
            showPic.Join();
                Thread.Sleep(1800);
            if (TamagochiPicture._gameOn == false)
            {
                Boxtimer.Stop();
                Boxtimer.Dispose();
                Console.Clear();
                Console.CursorSize=100; 
                Console.WriteLine("******GAME OVER******"); 
                Console.ReadLine();
            }

        }
    }
}
//-cure after 3 times not respond+
//-timer for scores
//-start game
//-winBox against pic
//-list of requests read/write
//-resultTab











