using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Modul6_1302213020
{
    class SayaTubeVideo
    {
        private int id, playCount;
        private string title;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            this.playCount = 0;
            this.id = new Random().Next(10000,99999);
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: "+ this.id);
            Console.WriteLine("Title: "+ this.title);
            Console.WriteLine("Play Count: "+ this.playCount);
        }

        public int getPlayCount() { return this.playCount; }
    
        public string getTitle() { return this.title; }
    }
}
