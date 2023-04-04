using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using static System.Console;

namespace HW_Tamagochi
{
    internal class RequestAll
    {
        internal static string[] Request { get; set; }

        internal static void RequestRead()
        {
            int SIZE = 0; 
            Request = new string[SIZE];

            string filePath = "Request.txt";
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string AllFile = sr.ReadToEnd();
                    foreach (char i in AllFile)
                    {
                        if (i == '\n') SIZE++;  
                    }
                    Request = AllFile.Split((char)10);
                }
            }
        }
    }
}
