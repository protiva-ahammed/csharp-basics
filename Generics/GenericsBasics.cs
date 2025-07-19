using System.IO.Pipes;
using System.Reflection;

namespace practices_basics.Generics
{

    public class GenericsBasics
    {
        // public void Dispplay(int[] a)
        // {
        //     for (int i = 0; i < a.Length; i++)
        //     {
        //         Console.Write(a[i] + " ");
        //     }
        // }
        // public void Dispplay(String[] a)
        // {
        //     for (int i= 0; i < a.Length; i++) {
        //         Console.Write(a[i] + " ");
        //     }
        // }

         public void Dispplay<T>(T [] a )
        {
            for (int i= 0; i < a.Length; i++) {
                Console.Write(" " + a[i] + " ");
            }
        }
    }
}