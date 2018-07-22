using System;

// A playlist is considered a repeating playlist if any of the songs contain a reference to a previous song in the playlist. 
// Otherwise, the playlist will end with the last song which points to null.
// Implement a function IsRepeatingPlaylist that returns true if a playlist is repeating or false if it is not.
// For example, the following code prints "True" as both songs point to each other.

namespace Playlist
{
    class Song
    {
        string name;
        public Song NextSong { get; set; }

        public Song(string name)
        {
            this.name = name;
        }

        public bool IsRepeatingPlaylist()
        {
            Song slow, fast;

            slow = fast = NextSong;

            while (true)
            {
                if (NextSong == null)
                {
                    return false;
                }
                slow = slow.NextSong;
                if (fast.NextSong != null)
                {
                    fast = fast.NextSong.NextSong;
                }
                else
                {
                    return false;
                }
                if (fast == null || slow == null)
                {
                    return false;
                }
                if (slow == fast)
                {
                    return true;
                }
            }
        }

        public static void Main(string[] args)
        {
            Song first = new Song("Hello");
            Song second = new Song("Eye of the tiger");

            first.NextSong = second;
            second.NextSong = first;

            Console.WriteLine(first.IsRepeatingPlaylist());
        }
    }
}
