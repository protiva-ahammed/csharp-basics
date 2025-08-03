using System.Runtime;

namespace practices_basics.OOP
{


    public class Instrument
    {

        // This method is defined in the base class, 
        // but child classes are allowed to override it to provide their own behavior.
        public virtual void Play()
        {
            Console.WriteLine("Playing an instrument");
        }
    }

    public class Piano : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("The piano is playing");
        }
    }

    public interface IPlayable

    {
        void Play();
    }

public class Guitar : IPlayable
{
    public void Play()
    {
        Console.WriteLine("The guitar is playing");
    }
}
}