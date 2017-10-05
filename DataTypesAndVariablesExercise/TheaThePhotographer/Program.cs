using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double picturesTaken = double.Parse(Console.ReadLine());
            double secondsToFilterOnePicture = double.Parse(Console.ReadLine());
            double picturesToUpload = double.Parse(Console.ReadLine());
            double secondsToUploadPerPicture = double.Parse(Console.ReadLine());

            double picsToUpload = Math.Ceiling(picturesToUpload);

            double totalSecondsToFilter = secondsToFilterOnePicture * picturesTaken;

            double totalFilteringTime = picturesTaken * secondsToFilterOnePicture;
            double percentageToUpload = (picturesToUpload / 100) * picturesTaken;

            double totalUploadTime = percentageToUpload * secondsToUploadPerPicture;

            double totalSeconds = totalFilteringTime + totalUploadTime;


            int days = 0;
            int hours = 0;
            int minutes = 0;
            int seconds = 0;


            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
            Console.WriteLine($"{time:d\\:hh\\:mm\\:ss}");






        }
    }
}
