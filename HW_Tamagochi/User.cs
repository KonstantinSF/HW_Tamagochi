using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Console; 

namespace HW_Tamagochi
{
    internal class User
    {
        public string _name { get; set; }
        public string _score { get; set; }
        public DateTime _time { get; set; }
        public User()
        {
            _name = string.Empty;
            _score = null;
            _time = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{this._name}\t\t\t{this._time.ToLongDateString()}\t\t{this._score}";
        }
        public void RatingTableWrite()
        {
            string path = "RatingTable.txt";
            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    sw.WriteLine(this.ToString()); 
                }
            }
        }


    }
}



