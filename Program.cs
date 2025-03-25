using System;

namespace modul6_103022300141
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser tubagus = new SayaTubeUser("Tubagus");
            SayaTubeVideo video1 = new SayaTubeVideo("Review Film The Batman oleh Tubagus");
            tubagus.AddVideo(video1);
            SayaTubeVideo video2 = new SayaTubeVideo("Review Film Hangover oleh Tubagus");
            tubagus.AddVideo(video2);
            SayaTubeVideo video3 = new SayaTubeVideo("Review Film Pulp Fuction oleh Tubagus");
            tubagus.AddVideo(video3);
            SayaTubeVideo video4 = new SayaTubeVideo("Review Film The Call oleh Tubagus");
            tubagus.AddVideo(video4);
            SayaTubeVideo video5 = new SayaTubeVideo("Review Film Burning oleh Tubagus");
            tubagus.AddVideo(video5);
            SayaTubeVideo video6 = new SayaTubeVideo("Review Film Beef oleh Tubagus");
            tubagus.AddVideo(video6);
            SayaTubeVideo video7 = new SayaTubeVideo("Review Film Saekano Tubagus");
            tubagus.AddVideo(video7);
            SayaTubeVideo video8 = new SayaTubeVideo("Review Film 3 Hari untuk selamanya oleh Tubagus");
            tubagus.AddVideo(video8);
            SayaTubeVideo video9 = new SayaTubeVideo("Review Film Tenggelamnya kapal van der wick oleh Tubagus");
            tubagus.AddVideo(video9);
            SayaTubeVideo video10 = new SayaTubeVideo("Review Film Gadis Kretek oleh Tubagus");
            tubagus.AddVideo(video10);

            tubagus.PrintAllVideoPlayCount();

        }
    }
}