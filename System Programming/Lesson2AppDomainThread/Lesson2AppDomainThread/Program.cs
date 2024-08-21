using System.ComponentModel.Design;
using System.Threading.Channels;

internal class Program
{
    static void SomeMethod()
    {
        for (int i = 0; i < 1000; i++)
        {
            Console.Write('x');
        }
        Console.WriteLine();
        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} {Thread.CurrentThread.Name}");
    }

    static void SomeMethod1()
    {

        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} {Thread.CurrentThread.Name}");

        Console.WriteLine("Thread Started");
        Thread.Sleep(1000);
        Console.WriteLine("Thread Finished");
    }

    static void Foo(int i) { Console.WriteLine(i * 19); }

    static void SomeMethodWithParams(object? obj)
    {
        Console.WriteLine(obj);
    }

    private static void Main(string[] args)
    {
        //Thread thread = new(SomeMethod);
        //thread.Name = "kamil";
        ////thread.Priority = ThreadPriority.Highest;
        ////thread.Priority = ThreadPriority.Lowest;

        //thread.Start();

        //for (int i = 0; i < 1000; i++)
        //{
        //    Console.Write('y');
        //}

        //Thread.Sleep(2000);
        //Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} {Thread.CurrentThread.Name}");

        //var thread = new Thread(SomeMethod1);
        //thread.IsBackground = true;
        //thread.Start();
        ////Thread.Sleep(2000);
        //Console.Write('d');


        //Thread thread = new(() =>
        //{
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        Console.WriteLine("salam");
        //    }
        //});

        //thread.Start();


        //Thread th = new(SomeMethodWithParams);
        //th.Start("salam");

        //Thread th = new(obj => Console.WriteLine(obj));
        //th.Start("salam");

        //Thread th = new Thread(() =>
        //{
        //    Foo(6);
        //});

        //th.Start();


        //for(int i = 0; i < 10; i++)
        //{
        //    int tt = i;
        //    Thread t = new(() => Console.WriteLine(tt));
        //    t.Start();
        //}

        //var str = "Miro";

        //Thread t = new(() => Console.WriteLine(str));

        //str = "Talo";
        //Thread t1 = new(() => Console.WriteLine(str));

        //t.Start();
        //t1.Start();


        Thread t = new(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine('x');
                Thread.Sleep(100);
            }
        });

        t.Start();

        Console.WriteLine("0000000000000");

        t.Join();

        Console.WriteLine("Hello");
    }
}