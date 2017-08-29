using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Online_Radio_Database
{
   public class ValidSong
   {
       private const int ArtistMinLength = 3;
       private const int ArtistMaxLength = 20;
       private const int NameMinLength = 3;
       private const int NameMaxLength = 30;
       private const int MinutesMin = 0;
       private const int MinutesMax = 14;
       private const int SecondsMin = 0;
       private const int SecondsMax = 59;

        private string artist;
       private string song;
       private int minutes;
       private int seconds;
       public string Artist {
            get { return this.artist; }
           set
            {//"Artist name should be between 3 and 20 symbols."
                if (value.Length<ArtistMinLength|| value.Length>ArtistMaxLength)
                {
                    throw new InvalidArtistNameException(ArtistMinLength,ArtistMaxLength);
                }
                this.artist = value;
            }
        }

       public string Song
       {
           get { return this.song; }
           set
           {//Song name should be between 3 and 30 symbols. 
                if (value.Length<3 || value.Length>30)
                {
                    throw new InvalidSongException();
                }
               this.song = value;
           }
       }

       public int Minutes { get; set; }
       public int Seconds { get; set; }

       
   }
}
