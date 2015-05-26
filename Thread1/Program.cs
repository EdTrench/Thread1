using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Thread1
{
    class Program
    {

        static void Main(string[] args)
        {
            var m = new Messenger("Hello Fred & Will");
            Thread t = new Thread(m.ShowMessage);
            t.Start();

            Console.WriteLine("Press ENTER to cancel");
            Console.ReadLine();

            m.Cancel();
            t.Join();

            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
