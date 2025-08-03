using System.Runtime;

namespace practices_basics.OOP
{
    public class PoolBase
    {

        public int chlorineLevel;
        public int waterLevel;
        public PoolBase(int chlorine, int water)
        {
            chlorineLevel = chlorine;
            waterLevel = water;
        }
        public void PoolInfo()
        {
            Console.WriteLine($"Pool: {chlorineLevel}, {waterLevel}");
        }

    }

public class ToSwim : PoolBase

{
    public int heatLevel;


    public ToSwim(int chlorine, int water, int heat): base(chlorine, water)
    {
        heatLevel = heat;
    }
    public void ToSwimInfo()
    {
        Console.WriteLine($"ToSwim : {chlorineLevel}, {waterLevel}, {heatLevel}");
    }
}
}