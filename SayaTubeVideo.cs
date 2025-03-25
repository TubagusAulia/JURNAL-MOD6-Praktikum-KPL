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
            if (string.IsNullOrEmpty(title) || title.Length > 200)
            {
                throw new ArgumentException("Judul tidak valid.");
            }

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount (int i)
        {
            if (i < 1 || i > 25000000)
            {
                throw new ArgumentException("Penambahan PlayCount tidak valid.");          
            } 

            try
            {
                checked
                {
                    this.playCount += i;
                }
            } catch (OverflowException)
            {
                Console.WriteLine("Penambahan PlayCount mengakibatkan Overflow");
            }

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
