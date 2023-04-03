using System.IO;
using System.Net;
using static System.Console;

namespace HW_Tamagochi
{
    internal class RequestAll
    {
        public static string[] Request { get; set; }

        internal static void RequestRead()
        {
            Request = new string[20];
            string filePath = "Request.txt";
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string AllFile = sr.ReadToEnd();
                    Request = AllFile.Split((char)10);
                }
            }
        }
    }
}
