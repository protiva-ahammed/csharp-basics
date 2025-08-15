namespace csharp_basics.DelicateEventHandling
{
    public delegate void SongEventHandler(string songTitle);

    public class MusicPlayer

    {
        public event SongEventHandler SongPlayed;

        public event SongEventHandler SongPaused;

        public event SongEventHandler SongStopped;

        public event SongEventHandler SongSkipped;

        public void Play(string songTitle)

        {

            Console.WriteLine($"Now playing: {songTitle}");

            SongPlayed?.Invoke(songTitle);

        }

        public void Pause(string songTitle)

        {

            Console.WriteLine($"Paused: {songTitle}");

            SongPaused?.Invoke(songTitle);

        }

        public void Stop(string songTitle)

        {

            Console.WriteLine($"Stopped: {songTitle}");

            SongStopped?.Invoke(songTitle);

        }
        public void Skip(string currentSongTitle, string nextSongTitle)

        {

            Console.WriteLine($"Skipped from: {currentSongTitle} to: {nextSongTitle}");

            SongSkipped?.Invoke(nextSongTitle);

        }


    }

}