using System;
using System.Threading;
using System.Windows.Forms;
using static System.Console;



namespace HW_Tamagochi
{
    internal class Program
    {
        bool _gameon = true;
        public static void Main(string[] args)
        {
            Thread showPic = new Thread(new ThreadStart(TamagochiPicture.ShowPic));
            showPic.Priority = ThreadPriority.BelowNormal;
            showPic.Start();

            TimerCallback tm = new TimerCallback(GetWindowsDialog.buttonClick);
            Thread.Sleep(3000);
            System.Threading.Timer boxTimer = new System.Threading.Timer(tm, null, 0, 2500);


            //Console.WriteLine("Press Enter to end program.");
            if (TamagochiPicture._gameOn == false)
            {
                showPic.Abort();
            }
            showPic.Join();
                Thread.Sleep(1800);
            if (TamagochiPicture._gameOn == false)
            {
                boxTimer.Dispose();
                Console.Clear();
                Console.CursorSize=100; 
                Console.WriteLine("******GAME OVER******"); 
                Console.ReadLine();
            }

        }
    }
}
//-specific requirements
//-timer for scores
//-start game
//-winBox against pic
//-list of requests read/write
//-resultTab











