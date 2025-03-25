using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300141
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo (string title)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount (int i)
        {
            this.playCount += i;
        }

        public void PrintVideoDetais ()
        {
            Console.WriteLine("( ID : " + this.id + " || Judul : " + this.title + " || Jumlah Tayang : " + this.playCount + " )");
        }

        public int getPlayCount ()
        {
            return this.playCount;
        }
    }
}
