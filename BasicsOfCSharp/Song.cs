using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    class Song
    {
        public string title2;
        public string artists;
        public int duration;
        public static int songCount = 0;

        public Song(string aTitle2, string aArtists, int aDuration)
        {
            title2 = aTitle2;
            artists = aArtists;
            duration = aDuration;
            songCount++;
        }

        public int getSongCount()
        {
            return songCount;
        }
    }
}
