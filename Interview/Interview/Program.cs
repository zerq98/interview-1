using Interview.Task4;
using Interview.Task5;
using System;
using System.Threading.Tasks;

namespace Interview
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("start");

            //var tester = new Tester5();
            //await tester.Test();

            //Console.WriteLine("stop");

            var tester = new Tester4();
            tester.Test();
            Console.ReadKey();

        }
    }
}
