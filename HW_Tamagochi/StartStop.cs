using System;
using System.Configuration;
using System.Diagnostics;
using System.Threading;
using static System.Console;

namespace HW_Tamagochi
{

    internal class StartStop
    {
        public static string score;
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
        public static System.Timers.Timer messageBoxtimer;
        public static System.Timers.Timer ShowPictimer;
        public static Stopwatch scoreCount = new Stopwatch();
        public static bool _startGame { get; set; }
        public static bool _stopGame { get; set; }

        public static void Start()
        {
                Thread showPic = new Thread(new ThreadStart(TamagochiPicture.ShowPic));
                showPic.Priority = ThreadPriority.BelowNormal;
                showPic.Start();
                SetTimerShowPic();
                SetTimerMessageBox();
                scoreCount.Start();
                if (TamagochiPicture.gaming == false)
                {
                    showPic.Abort();
                }
                showPic.Join();
                Thread.Sleep(600);
                if (TamagochiPicture.gaming == false)
                {
                
                    ShowPictimer.Stop();
                    ShowPictimer.Dispose();
                    Console.Clear();
                    Stop(); 
                }
        }
        public static void Stop()
        {
            //_startGame = false;
            
            StartStop.scoreCount.Stop();
            TimeSpan ts = StartStop.scoreCount.Elapsed;
            string score = string.Format("{0:00}, {1:00}", ts.Minutes, ts.Seconds);
            score = score.Replace(", ", "");
            User user1 = new User();
            WriteLine($"***********GAME OVER*********\nYour score is : {score}\nPlease Enter your name: ");
            user1._name = ReadLine();
            user1._score = score;
            user1.RatingTableWrite(); 
        }
    }
}

