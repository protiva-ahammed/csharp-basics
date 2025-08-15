namespace csharp_basics.Models
{

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

