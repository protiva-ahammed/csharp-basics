// See https://aka.ms/new-console-template for more information


using System.IO.Pipes;
using System.Reflection;
using practices_basics.App;
using practices_basics.MultipleThreadings;

namespace practices_basics
{
    class Program
    {

        // static async Task Main(string[] args)
        // {

        //     await new AppRunner().Run();

        // }

        static void Main(string[] args)
        {
             AppRunner.Run();
        }

    }
}