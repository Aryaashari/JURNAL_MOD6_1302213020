using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
            Contract.Requires(title.Length <= 200);
            Contract.Requires(title != null);

            try
            {
                checked
                {
                    this.title = title;
                    this.playCount = 0;
                    this.id = new Random().Next(10000, 99999);
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }

        public void IncreasePlayCount(int playCount)
        {
            Contract.Requires(playCount <= 25000000);
            Contract.Requires(playCount > 0);

            try
            {
                checked
                {
                    this.playCount += playCount;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
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
