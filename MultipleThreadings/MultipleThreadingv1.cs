using System.IO.Pipes;
using System.Reflection;

namespace practices_basics.MultipleThreadings
{

    public class MultipleThreadingv1
    {

        public void CountDesc()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("from thread1 ", i);
                Thread.Sleep(200);
            }
            Console.WriteLine("from thread1 completed . ");

        }

        public void CountAsc()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("from thread2 ", i);
                Thread.Sleep(100);

            }

            Console.WriteLine("from thread2 completed . ");

        }

    }

}
