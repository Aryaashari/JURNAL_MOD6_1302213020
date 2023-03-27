using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
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
            Debug.Assert(username != null);
            Debug.Assert(username.Length <= 100);

            this.uploadedVideos = new List<SayaTubeVideo>();
            Username = username;
            this.id = new Random().Next(10000, 99999);
                
            
        }

        public int GetTotalVideoPlayCount()
        {
            int jumlah = 0;
            try
            {
                for (int i=0;i < uploadedVideos.Count; i++)
                {
                    checked {
                        jumlah += uploadedVideos[i].getPlayCount();
                    }
                }

                return jumlah;
            } catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return jumlah;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            Debug.Assert(video != null);
            Debug.Assert(video.getPlayCount() <= int.MaxValue);

            
            this.uploadedVideos.Add(video);
            
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: "+ this.Username);
            int i = 0;
            while (i<this.uploadedVideos.Count && i<8)
            {
                Console.WriteLine("Video "+ (i + 1) + " judul: "+ this.uploadedVideos[i].getTitle());
                i++;
            }

            
        }
    }
}
