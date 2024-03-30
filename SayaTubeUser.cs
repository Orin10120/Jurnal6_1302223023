using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223023
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private string username;

        public SayaTubeUser(string  username)
        {
            Contract.Requires(username != null && username.Length <= 100);
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
            this.id = randomID();
        }

        public int randomID()
        {
            Random rand = new Random();
            return 10000 + rand.Next(99000);
        }

        public int getTotalVideoCount()
        {
           int jumlah = 0;
           for (int i = 0; i < uploadedVideos.Count; i++)
            {
               jumlah = jumlah + uploadedVideos[i].getCountTotal();
            }
           return jumlah;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            Debug.Assert(video != null);
            Debug.Assert(video.getCountTotal() > 10000);
            uploadedVideos.Add(video);
        }

        public void printAllVideoPlaycount()
        {
            Console.WriteLine("User: " + username);
            for (int i = 0;i < uploadedVideos.Count;i++)
            {
                Console.WriteLine("Video "+ i + uploadedVideos[i]);
            }
        }
    }
}
