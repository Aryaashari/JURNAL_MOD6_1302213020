using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul6_1302213020
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(string username)
        {
            this.uploadedVideos= new List<SayaTubeVideo>();
            Username = username;
            this.id = new Random().Next(10000, 99999);
        }

        public int GetTotalVideoPlayCount()
        {
            int jumlah = 0;
            for (int i=0;i < uploadedVideos.Count; i++)
            {
                jumlah += uploadedVideos[i].getPlayCount();
            }

            return jumlah;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            this.uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: "+ this.Username);
            for (int i=0; i<this.uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video "+ (i + 1) + " judul: "+ this.uploadedVideos[i].getTitle());
            }
        }
    }
}
