using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab01
{
    class Program
    {
        static bool IsPrime(int n)
        {
            for (int i = 2; i < n; i += 1)
                if (n % i == 0)
                    return false;
            return true;
        }

        static int BiggestSmallPrime1(int n)
        {
            int i = 0, ret = -1;
            do
            {
                if (IsPrime(i))
                    ret = i;
                i += 1;
            }
            while (i < n);
            return ret;
        }

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            myClass.MyEventHandler += (object sender, MyEventArgs e) => {
                Console.WriteLine($"DoStuff was called {e.Count} times so far");
            };

            myClass.DoStuff();
            myClass.DoStuff();
            myClass.DoStuff();

            int[] array = new int[] { 1, 3, 5, 7, 9 };

            Thread thread1 = new Thread(() => {
                Console.WriteLine($"Start fir: {Thread.CurrentThread.Name} {DateTime.Now.ToString("hh:mm:s:ms")}");

                foreach (int el in array)
                    Console.WriteLine($"{el} => {BiggestSmallPrime1(el)}");
            });
            thread1.Name = "primul thread";
            thread1.Start();
            Console.ReadLine();
        }
    }
}
