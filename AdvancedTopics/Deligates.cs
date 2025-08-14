namespace practices_basics.AdvancedTopics
{

    //A delegate in C# is indeed a type-safe function pointer 
    // that stores references to methods and invokes them indirectly.
    //even switch them dynamically at runtime
    public delegate void SongEventHandler(string songTitle);
    public class MusicPlayer
    {

        public event SongEventHandler SongPlayed;

        // SongEventHandler is a deligate which stores reference of
        //functions whic are events now as pauused,stopped,skipped

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
    public class Subscriber

    {

        public string Name { get; }

        public Subscriber(string name)

        {

            Name = name;

        }

        public void SongPlayedHandler(string songTitle)

        {

            Console.WriteLine($"{Name} is now enjoying: {songTitle}");

        }

        public void SongPausedHandler(string songTitle)

        {

            Console.WriteLine($"{Name} paused: {songTitle}");

        }

        public void SongStoppedHandler(string songTitle)

        {

            Console.WriteLine($"{Name} stopped: {songTitle}");

        }

        public void SongSkippedHandler(string nextSongTitle)

        {

            Console.WriteLine($"{Name} skipped to: {nextSongTitle}");

        }

        }
    }