using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using practices_basics.Constants;
using practices_basics.Enums;
using practices_basics.Generics;
using practices_basics.Models;
using practices_basics.MultipleThreadings;

namespace practices_basics.App
{

    public class AppRunner
    {
        public void Run()
        {
            MultiThreading();
            Generics();
            UseOfEnums();
            UseOfConstantsErrMsg();
            UseOfGetSet();

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

        private void Generics()
        {
            // <T> can be class methods feilds
            // as in java 8 only class,constructor,method 
            // Generics in c# is for taking any kind of parameters
            // without ambiguity of the parameter type
            // more generealized code
            // real world many time we do not lnow what will be users input
            // but want to do the common task anyways
            int[] a = new int[] { 12, 45, 7, 9 };
            String[] s = new string[] { "abc", "efg" };
            GenericsBasics obj = new GenericsBasics();
            // obj.Dispplay(a);
            // obj.Dispplay(s);--> results in error while type is different
            obj.Dispplay(a);
            obj.Dispplay(s);

        }

        private void UseOfEnums()
        {
            Console.WriteLine(Commands.LightUp.ToString());
            Console.WriteLine(Commands.ShowAmount.ToString());
            Console.WriteLine((int)Commands.LightUp);
            Console.WriteLine(Commands.Initialize);

        }

        private void UseOfConstantsErrMsg ()
        {
            int a ;
            string s = Console.ReadLine();
            a = int.Parse(s);
            if (a < AppConstants.THRESHOLD)
                throw new NotImplementedException(ErrorMessages.NEGATIVE_NUMBER);
            Console.WriteLine("Entered  positive number : {0}",a);
        }

        private void UseOfGetSet()
        {
            PickingArranger pickProduct = new PickingArranger();
            ProductPriceData productPriceData = new ProductPriceData();
            Console.WriteLine("Entered number to be set and get : ");

            pickProduct.Amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pickProduct.Amount + " setted value ");
            Console.WriteLine("Entered product price amount to be set and get : ");

            productPriceData.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(productPriceData.Price  + " setted value ");

        }
    }
}
