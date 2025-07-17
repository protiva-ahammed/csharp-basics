using practices_basics.MultipleThreadings;

namespace practices_basics.App
{

    public class AppRunner
    {
        public void Run()
        {
            MultiThreading();

        }
        private void MultiThreading()
        {

            // Thread is AnonymousPipeClientStream execution path of a program
            // MulticastDelegate-thread to perform diff task at same time concurrently
            // currently running thread is main thread  whic is int System.Threading 

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = " main thread ";
            Console.WriteLine(mainThread.Name);
            MultipleThreadingv1 obj = new MultipleThreadingv1();
            Thread thread1 = new Thread(obj.CountDesc);

            Thread thread2 = new Thread(obj.CountAsc);
            thread1.Start();
            thread2.Start();

            Console.WriteLine("from main thread completed . ");

            Console.ReadKey();
        }
    }
}
