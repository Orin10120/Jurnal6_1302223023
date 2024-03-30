using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223023
{
     class Program
    {
        static void Main(string[] args)
        {
            string nama = "Rindang bani Isyan";
            SayaTubeVideo video1 = new SayaTubeVideo("film 1" + nama);
            SayaTubeVideo video2 = new SayaTubeVideo("film 2 " + nama);
            SayaTubeVideo video3 = new SayaTubeVideo("film 3 " + nama);
            SayaTubeVideo video4 = new SayaTubeVideo("film 4 " + nama);
            SayaTubeVideo video5 = new SayaTubeVideo("film 5 " + nama);
            SayaTubeVideo video6 = new SayaTubeVideo("film 6 " + nama);
            SayaTubeVideo video7= new SayaTubeVideo("film 7 " + nama);
            SayaTubeVideo video8 = new SayaTubeVideo("film 8 " + nama);
            SayaTubeVideo video9 = new SayaTubeVideo("film 9 " + nama);
            SayaTubeVideo video10 = new SayaTubeVideo("film 10 " + nama);

            SayaTubeUser user = new SayaTubeUser(nama);
            user.AddVideo(video1);
            user.AddVideo(video2);
            user.AddVideo(video3);
            user.AddVideo(video4);
            user.AddVideo(video5);
            user.AddVideo(video6);
            user.AddVideo(video7);
            user.AddVideo(video8);
            user.AddVideo(video9);
            user.AddVideo(video10);

            user.printAllVideoPlaycount();

        }
    }
}
