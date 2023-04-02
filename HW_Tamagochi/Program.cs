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
        public static void SetTimerBox()
        {
            Boxtimer = new System.Timers.Timer(2500);
            Boxtimer.Elapsed += GetWindowsDialog.buttonClick;
            Boxtimer.AutoReset = true;
            Boxtimer.Enabled = true;
        }
        public static void SetTimerShowPic()
        {
            ShowPictimer = new System.Timers.Timer(60000 * 2);
            ShowPictimer.Elapsed += TamagochiPicture.ShowPicTimer;
            ShowPictimer.AutoReset = false;
            ShowPictimer.Enabled = true;
        }
        bool _gameon = true;
        public static System.Timers.Timer Boxtimer;
        public static System.Timers.Timer ShowPictimer;

        public static void Main(string[] args)
        {
            Thread showPic = new Thread(new ThreadStart(TamagochiPicture.ShowPic));
            showPic.Priority = ThreadPriority.BelowNormal;
            showPic.Start();
            SetTimerShowPic();
            SetTimerBox();
            if (TamagochiPicture.gaming == false)
            {
                showPic.Abort();
            }
            showPic.Join();
            Thread.Sleep(1200);
            if (TamagochiPicture.gaming == false)
            {
                ShowPictimer.Stop();
                ShowPictimer.Dispose();
                Boxtimer.Stop();
                Boxtimer.Dispose();
                Console.Clear();
                Console.CursorSize = 100;
                Console.WriteLine("******GAME OVER******");
                Console.ReadLine();
            }
        }
    }
}
//-cure after 3 times not respond+
//-living for 2 minutes+; 
//-unique requests from array+; 
//-timer for scores+
//-winBox against pic
//-start game
//-list of requests read/write to file
//-resultTab
//-XLM file











