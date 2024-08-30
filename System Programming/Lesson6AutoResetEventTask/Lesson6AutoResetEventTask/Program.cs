using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

internal class Program
{
    #region AutoResetEvent

    //private static AutoResetEvent blok = new(false);
    //private static AutoResetEvent blok1 = new(false);
    //private static void Main(string[] args)
    //{
    //    var t = new Thread(SomeProc);
    //    t.Start();
    //    Console.WriteLine("Starting Main");

    //    blok.WaitOne();

    //    for (int i = 0; i < 10; i++)
    //    {
    //        Console.WriteLine($"Main: {i}");
    //        Thread.Sleep(100);
    //    }
    //    // blok1.Set();
    //}

    //private static void SomeProc()
    //{
    //    Console.WriteLine("Starting SomeProc");
    //    Thread.Sleep(5000);
    //    Console.WriteLine("Uraaaa");

    //    blok.Set();

    //    blok1.WaitOne();

    //    for (int i = 0; i < 10; i++)
    //    {
    //        Console.WriteLine($"Process: {i}");
    //        Thread.Sleep(100);
    //    }
    //}

    #endregion

    // Thread
    // ThreadPool
    // TPL (Task Paralel Library)

    #region Create Task

    //private static void TaskMethod(string name)
    //{
    //    Console.WriteLine($"{name} is running. Id: {Thread.CurrentThread.ManagedThreadId} IsThreadPoolThread: {Thread.CurrentThread.IsThreadPoolThread}");
    //}

    //static void Main(string[] args)
    //{
    //    //var task = new Task(() => { Console.WriteLine("task"); });
    //    //task.Start();

    //    var task = new Task(() => { TaskMethod("Task 1"); });
    //    task.Start();

    //    new Task(() => { TaskMethod("Task 2"); }).Start();

    //    var t1 = Task.Run(() => { TaskMethod("Task 3"); });

    //    var t2 = Task.Factory.StartNew(() => { TaskMethod("Task 4"); });

    //    var t3 = Task.Factory.StartNew(() => { TaskMethod("Task 5"); }, TaskCreationOptions.LongRunning);



    //    Console.ReadKey();
    //}


    #endregion

    #region Working

    private static int TaskMethod(string name)
    {
        Console.WriteLine($"{name} is running. Id: {Thread.CurrentThread.ManagedThreadId} IsThreadPoolThread: {Thread.CurrentThread.IsThreadPoolThread}");
        Thread.Sleep(2000);

        return 42;
    }

    static void Main(string[] args)
    {
        //var t = new Task<int>(() => TaskMethod("Task 1"));
        //t.Start();

        //var result = t.Result;
        //Console.WriteLine(result);
        //Console.WriteLine("salam");

        //var t2 = new Task<int>(() => TaskMethod("Task 2"));
        //t2.RunSynchronously();
        //TaskMethod("Main");

        //var t1 = new Task<int>(() => TaskMethod("Task2"));

        //t1.Start();

        //t1.ContinueWith(t =>
        //{
        //    Console.WriteLine($"Result: {t.Result}. Id: {Thread.CurrentThread.ManagedThreadId} IsThreadPoolThread: {Thread.CurrentThread.IsThreadPoolThread}");
        //});

        //Console.ReadKey();



    }



    #endregion
}