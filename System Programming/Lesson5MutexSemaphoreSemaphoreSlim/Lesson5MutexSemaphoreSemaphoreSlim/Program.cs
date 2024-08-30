
internal class Program
{
    #region Lock
    //static int count = 0;
    //static object _sync = new object();
    //private static void Increment()
    //{
    //    lock (_sync)
    //    {
    //        count = 0;
    //        for (int i = 0; i < 10; i++)
    //            Console.WriteLine($"{Thread.CurrentThread.Name}: {++count}");
    //    }
    //}
    //private static void Main(string[] args)
    //{
    //    for (int i = 0; i < 5; i++)
    //    {
    //        var thread = new Thread(Increment);
    //        thread.Name = $"Thread{i}";
    //        thread.Start();
    //    }
    //}
    #endregion

    #region Mutex

    //static int count = 0;
    //static object _sync = new();
    //static Mutex _mutexObj = new();
    //private static void Increment()
    //{
    //    _mutexObj.WaitOne();

    //    count = 0;
    //    for (int i = 0; i < 10; i++)
    //        Console.WriteLine($"{Thread.CurrentThread.Name}: {++count}");

    //    _mutexObj.ReleaseMutex();
    //}
    //private static void Main(string[] args)
    //{
    //    for (int i = 0; i < 5; i++)
    //    {
    //        var thread = new Thread(Increment);
    //        thread.Name = $"Thread{i}";
    //        thread.Start();
    //    }
    //}

    #endregion

    #region Mutex (external thread)

    //static void Main(string[] args)
    //{
    //    var mutexName = "mirtalib";

    //    using (var mutex = new Mutex(false, mutexName))
    //    {
    //        if (mutex.WaitOne(10000))
    //        {
    //            Console.WriteLine("Running process");
    //            Console.WriteLine("Press any enter for exit");
    //            Console.ReadLine();

    //            mutex.ReleaseMutex();
    //        }
    //        else
    //        {
    //            Console.WriteLine("Another process is running");
    //            Environment.Exit(0);
    //        }
    //    }
    //}



    #endregion

    #region Semaphore

    //static void Main(string[] args)
    //{
    //    var semaphore = new Semaphore(2, 2, "mirtalib");

    //    for (int i = 0; i < 6; i++)
    //    {
    //        ThreadPool.QueueUserWorkItem(SomeMethod, semaphore);
    //    }

    //    Thread thread = new(SomeMethod1);
    //    thread.Start(semaphore);

    //    Console.ReadKey();



    //}

    //private static void SomeMethod1(object? state)
    //{
    //    var s = state as Semaphore;
    //    bool st = false;

    //    if (s is not null)
    //    {
    //        while (!st)
    //        {
    //            if (s.WaitOne(1000))
    //            {
    //                try
    //                {
    //                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} got the key");
    //                    Console.WriteLine("10second");
    //                    Thread.Sleep(10000);
    //                }
    //                finally
    //                {
    //                    st = true;
    //                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} returned the key");
    //                    s.Release();
    //                }
    //            }
    //            else
    //            {
    //                Console.WriteLine($"Mister Thread {Thread.CurrentThread.ManagedThreadId} we dont have enough keys. Please wait...");
    //            }
    //        }
    //    }

    //}

    //private static void SomeMethod(object? state)
    //{
    //    var s = state as Semaphore;
    //    bool st = false;

    //    if (s is not null)
    //    {
    //        while (!st)
    //        {
    //            if (s.WaitOne(1000))
    //            {
    //                try
    //                {
    //                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} got the key");
    //                    Thread.Sleep(4000);
    //                }
    //                finally
    //                {
    //                    st = true;
    //                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} returned the key");
    //                    s.Release();
    //                }
    //            }
    //            else
    //            {
    //                Console.WriteLine($"Mister Thread {Thread.CurrentThread.ManagedThreadId} we dont have enough keys. Please wait...");
    //            }
    //        }
    //    }

    //}




    #endregion


    #region SemaphoreSlim

    static SemaphoreSlim slimSema = new(10);
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            var name = $"Thread{i}";
            var second = (2 + 2 * i) * 1000;

            new Thread(() =>
            {
                Console.WriteLine($"{name} waits for access");
                slimSema.Wait(second);
                Console.WriteLine($"{name} is working");
                Thread.Sleep(second);
                Console.WriteLine($"{name} completed");

                slimSema.Release();
            }).Start();
        }
    }




    #endregion
}