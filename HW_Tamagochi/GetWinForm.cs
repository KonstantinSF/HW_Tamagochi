using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using static System.Console; 


namespace HW_Tamagochi
{

    public class GetWindowsDialog
    {
        public static int _mastakes { get; set; }
        public static bool resultDialog { get; set; }

        //private static System.Threading.Timer boxTimer;
        public static string[] Requires =
        {
        "Feed me!!!",
        "Calm me down!!!",
        "Lull me!!!",
        "Scratch my back!!!",
        "Play with me!!!",
        "Let's walking!!!",
        "Warm me!!!"
        };
        
        public static void buttonClick(Object source, ElapsedEventArgs e)
        {
            if (GetWindowsDialog._mastakes%3 == 0&& GetWindowsDialog._mastakes!=0) 
            { 
            Program.Boxtimer.Stop();
            Cure.CureMe(true);
            }
            GetWindowsDialog._mastakes++; 
            DialogResult result;
            result = MessageBox.Show(GetWindowsDialog.Requires[new Random().Next(0, GetWindowsDialog.Requires.Length - 1)]);
            if (result == DialogResult.OK) GetWindowsDialog._mastakes--;
        }
    }
}


