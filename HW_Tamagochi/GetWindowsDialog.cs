using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Console; 


namespace HW_Tamagochi
{
    public class GetWindowsDialog
    {
        public static int _mistakes { get; set; }
        public static bool resultDialog { get; set; }
        public static int countRequires; 
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
        public static int[] UniqueSeq {  get; set; }
        public static int[] UniqueSequence()
        {
            int Count = Requires.Count(); 
            int [] sequence = new int[Count];
            for (int i = 0; i < Count; ++i) 
            {
                sequence[i]=new Random().Next(sequence.Count());
                for (int j=0; j<i; ++j)
                {
                    if (sequence[i] == sequence[j])
                    {
                        i--; break; 
                    }
                }
            }
            return sequence; 
        }
        public static void buttonClick(Object source, ElapsedEventArgs e)
        {
            if (countRequires%Requires.Count() == 0) UniqueSeq = UniqueSequence(); 
            if (_mistakes==3) 
            { 
            StartStop.messageBoxtimer.Stop();
            Cure.CureMe(true);
            }
            countRequires++;
            _mistakes++; 
            DialogResult result;
            result = MessageBox.Show(Requires[UniqueSeq[(countRequires-1)%Requires.Count()]]);
            if (result == DialogResult.OK&& _mistakes>0) _mistakes--;
        }
    }
}


