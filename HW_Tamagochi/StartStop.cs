using System;
using System.Threading;
using static System.Console;

namespace HW_Tamagochi
{

    internal class StartStop
    {
        public static void SetTimerMessageBox()
        {
            messageBoxtimer = new System.Timers.Timer(2500);
            messageBoxtimer.Elapsed += GetWindowsDialog.buttonClick;
            messageBoxtimer.AutoReset = true;
            messageBoxtimer.Enabled = true;
        }
        public static void SetTimerShowPic()
        {
            ShowPictimer = new System.Timers.Timer(60000 * 2);
            ShowPictimer.Elapsed += TamagochiPicture.ShowPicTimer;
            ShowPictimer.AutoReset = false;
            ShowPictimer.Enabled = true;
        }
        bool _gameon = true;
        public static System.Timers.Timer messageBoxtimer;
        public static System.Timers.Timer ShowPictimer;
        public static bool _startGame { get; set; }
        public static bool _stopGame { get; set; }

        public static void Start(bool _startGame)
        {
            if (_startGame)
            {
                Thread showPic = new Thread(new ThreadStart(TamagochiPicture.ShowPic));
                showPic.Priority = ThreadPriority.BelowNormal;
                showPic.Start();
                SetTimerShowPic();
                SetTimerMessageBox();
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
                    messageBoxtimer.Stop();
                    messageBoxtimer.Dispose();
                    Console.Clear();
                    Console.CursorSize = 100;
                    Console.WriteLine("******GAME OVER******");
                }
            }
            else Stop(); 
        }
        public static bool Stop()
        {
            _startGame = false;
            WriteLine($"The game result is {TamagochiPicture.score}");
            return _stopGame = true;
        }
    }
}
