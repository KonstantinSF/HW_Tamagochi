using System;
using System.Threading;
using System.Windows.Forms;
using static System.Console;



namespace HW_Tamagochi
{
    internal class Program
    {


        //static void Main(string[] args)

        //TamagochiPicture.ShowPic();
        //public class ThreadExample

        // The ThreadProc method is called when the thread starts.
        // It loops ten times, writing to the console and yielding
        // the rest of its time slice each time, and then ends.

        bool _gameon = true;

        
        public static void Main(string[] args)
        {
            Thread showPic = new Thread(new ThreadStart(TamagochiPicture.ShowPic));
            showPic.Priority = ThreadPriority.BelowNormal;
            showPic.Start();

            TimerCallback tm = new TimerCallback(GetWindowsDialog.buttonClick);

            System.Threading.Timer boxTimer = new System.Threading.Timer(tm, null, 0, 3000);


            //Console.WriteLine("Press Enter to end program.");
            if (TamagochiPicture._gameOn == false)
            {
                showPic.Abort();
            }
            showPic.Join();
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











