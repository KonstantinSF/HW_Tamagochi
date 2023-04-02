using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.Windows.Forms; 

namespace HW_Tamagochi
{
    internal class Cure
    {
        public static bool _startCure; 
        public static void CureMe(bool _startCure)
        {
            if (_startCure)
            {
                // GetWindowsDialog._mastakes = 0; 
                TamagochiPicture.curePic = true; 
                DialogResult result = MessageBox.Show (
                "I'm ill, please cure me!!!", 
                "Cure cure cure cure + red ALERT!!!", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _startCure = false;
                    Thread.Sleep(600);
                    Program.Boxtimer.Start();
                    TamagochiPicture.curePic = false; 
                }
                else
                {
                    TamagochiPicture.gaming = false;
                    StartStop.Stop(); 
                }
            }
        }
    }
}
