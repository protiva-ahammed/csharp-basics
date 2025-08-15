using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using csharp_basics.DelicateEventHandling;
using csharp_basics.Models;
using practices_basics.AsynchronousFunctionalities;
using practices_basics.Constants;
using practices_basics.DesignPatterns.CreationalPatterns;
using practices_basics.Enums;
using practices_basics.Generics;
using practices_basics.Models;
using practices_basics.MultipleThreadings;
using practices_basics.OOP;
using practices_basics.ToDoList;
namespace practices_basics.App
{

    public class AppRunner
    {
        public async Task Running()
        {
            MultiThreading();
            Generics();
            UseOfEnums();
            UseOfConstantsErrMsg();
            UseOfGetSet();
            ToDoList();
            LearnInheritance();
            LearnPolymorphism();
            LearnDesignPatternsSingleton();
            // await AsyncProgramming();

            AsyncCodings program = new AsyncCodings();
            Task task1 = program.DownloadDataAsync();
            Task task2 = program.DownloadDataAsync2();
            await Task.WhenAll(task1, task2);
            Console.WriteLine("All downloads completed.");
        }

        public static void Run()
        {
            // LibraryManaging();
            Mp3PlayerEventHandling();
        }

        private static void Mp3PlayerEventHandling()
        {
            MusicPlayer musicPlayer = new MusicPlayer();

            Subscriber subscriber1 = new Subscriber("User1");

            Subscriber subscriber2 = new Subscriber("User2");

            // obj->subscriber 1
            musicPlayer.SongPlayed += subscriber1.SongPlayedHandler;

            musicPlayer.SongPaused += subscriber1.SongPausedHandler;

            musicPlayer.SongStopped += subscriber1.SongStoppedHandler;

            musicPlayer.SongSkipped += subscriber1.SongSkippedHandler;

            // obj->subscriber 2
            musicPlayer.SongPlayed += subscriber2.SongPlayedHandler;

            musicPlayer.SongPaused += subscriber2.SongPausedHandler;

            musicPlayer.SongStopped += subscriber2.SongStoppedHandler;

            musicPlayer.SongSkipped += subscriber2.SongSkippedHandler;

            while (true)

            {

                Console.WriteLine("\nEnter the action (play, pause, stop, skip) or 'exit' to end:");

                string action = Console.ReadLine().ToLower();

                if (action == "exit")

                    break;

                Console.WriteLine("Enter the song title:");

                string songTitle = Console.ReadLine();

                switch (action)

                {

                    case "play":

                        musicPlayer.Play(songTitle);

                        break;

                    case "pause":

                        musicPlayer.Pause(songTitle);

                        break;

                    case "stop":

                        musicPlayer.Stop(songTitle);

                        break;

                    case "skip":

                        Console.WriteLine("Enter the next song title:");

                        string nextSongTitle = Console.ReadLine();

                        musicPlayer.Skip(songTitle, nextSongTitle);

                        break;

                    default:

                        Console.WriteLine("Invalid action. Please enter play, pause, stop, skip, or exit.");
                        
                        break;

                }

            }
        }


        private static void LibraryManaging()
        {
            LibraryManager.LibraryManage();
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

        private void UseOfConstantsErrMsg()
        {
            int a;
            string s = Console.ReadLine();
            a = int.Parse(s);
            if (a < AppConstants.THRESHOLD)
                throw new NotImplementedException(ErrorMessages.NEGATIVE_NUMBER);
            Console.WriteLine("Entered  positive number : {0}", a);
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
            Console.WriteLine(productPriceData.Price + " setted value ");

        }

        private void ToDoList()
        {

            bool running = true;
            while (running)
            {
                Console.WriteLine("Let Start to schedule ");
                Console.WriteLine("1. Add a task  ");
                Console.WriteLine("2. View the task Log ");
                Console.WriteLine("3. Mark the task as completed ");
                Console.WriteLine("4. Exist ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ToDoLists.AddTask();
                        break;
                    case "2":
                        ToDoLists.ViewTasks();
                        break;
                    case "3":
                        ToDoLists.CompleteTask();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again!");
                        break;

                }
            }

        }

        private void LearnInheritance()
        {

            //own obj
            //Can access both base and child methods
            ToSwim toSwimObj = new ToSwim(23, 30, 34);
            toSwimObj.PoolInfo();//method inherited from base
            toSwimObj.ToSwimInfo();//own method

            // derived class down type-casting 

            //Only allowed if PoolBase implements ToSwim.

            //Otherwise, this will throw a ClassCastException at runtime.
            // ToSwim toSwimChildObj = (ToSwim) new PoolBase(23, 32);


            // Upcasting: Assign ToSwim object to PoolBase reference
            //Object type: ToSwim
            //Reference type: PoolBase (upcast)
            PoolBase toSwimChildObj = new ToSwim(23, 45, 57);
            toSwimChildObj.chlorineLevel = 45;// own child class properties
            toSwimChildObj.PoolInfo();

            //Compile-time error: not accessible via base class
            // toSwimChildObj.ToSwimInfo(); //X
            // To call ToSwimInfo(), must downcast it back
            ((ToSwim)toSwimChildObj).ToSwimInfo();
        }

        private void LearnPolymorphism()
        {


            // assigning a child object (new Piano())
            //  to a base class reference (Instrument)
            // always allowed because every Piano is an Instrument
            Instrument piano = new Piano(); // upcasting

            // Not every Instrument is a Piano.
            // Piano piano = new Instrument();// Compile-time error
            piano.Play();

            //interface 
            Guitar guitar = new Guitar();
            guitar.Play();

            //base class 
            Instrument instrument = new Instrument();
            instrument.Play();
        }

        private void LearnDesignPatternsSingleton()
        {
            Database db1 = Database.GetInstance();
            Database db2 = Database.GetInstance();

            db1.Connect();
            Console.WriteLine(object.ReferenceEquals(db1, db2)); // Outputs: True
        }


    }
}
