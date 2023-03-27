using HW_Tamagochi;
using System.Threading;
namespace System.Windows.Forms
{


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
                //TamagochiPicture.ShowPic(); 
                showPic.Priority=ThreadPriority.BelowNormal;
                showPic.Start();
                {

                    MessageBox.Show("FEED ME");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("Main thread: Do some work.");
                        Thread.Sleep(1000);
                        if (i == 5 ) TamagochiPicture._gameOn = false;
                    }
                }

                //Console.WriteLine("Main thread: Call Join(), to wait until ThreadProc ends.");
                
                showPic.Abort();
                showPic.Join();
                Console.WriteLine("Press Enter to end program.");
                Console.ReadLine();
            }
        }
    }
}










