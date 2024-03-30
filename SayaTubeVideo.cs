using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223023
{
     class SayaTubeVideo
    {
        private int id;
        private string title;
        private int PlayCount;

        public SayaTubeVideo(string title)
        {
            Contract.Requires(title != null && title.Length <= 200);
            this.title = title;
            this.PlayCount = 0;
            this.id = randomID();

        }

        public void Title(string title)
        {
            this.title = title;
        }

        public string getTitle()
        {
            return title;
        }

        public int randomID()
        {
            Random rand = new Random();
            return 10000 + rand.Next(99000);
        }

        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount <= 25000000);
            Debug.Assert(playCount > 0);
            int updated;
            try
            {
                updated = checked(this.PlayCount + playCount);
            }catch (OverflowException)
            {
                Console.WriteLine("Jumlah penambahan count melebihi kapasitas");
                updated = this.PlayCount;
                
            }
            this.PlayCount = updated;
        }

        public int getCountTotal()
        {
            return PlayCount;
        }


        public void printVideoDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Total Playcount: " + PlayCount);
        }
    }
}
