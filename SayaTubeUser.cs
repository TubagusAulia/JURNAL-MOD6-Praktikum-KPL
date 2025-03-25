using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300141
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(string username)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.uploadedVideos = new List<SayaTubeVideo>();

        }

        public int GetTotalVideoPlayCount ()
        {
            int TotalVideoPlayCount = 0;
            for (int i = 0; i < uploadedVideos.Count; i++ )
            {
                TotalVideoPlayCount += uploadedVideos[i].getPlayCount();
            }

            return TotalVideoPlayCount;
        }

        public void AddVideo (SayaTubeVideo newVideo)
        {
            uploadedVideos.Add(newVideo);
        }

        public void PrintAllVideoPlayCount ()
        {
            Console.WriteLine("User : ", this.Username);
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Video " + (i + 1) + " ");
                uploadedVideos[i].PrintVideoDetais();
            }
        }
    }


}
