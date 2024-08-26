internal class Program
{
    class Singleton
    {
        private static Singleton _instance;
        private Singleton() { }
        private static object _sync = new object();
        public static Singleton GetSingleton()
        {
            lock (_sync)
            {
                _instance ??= new Singleton();
                return _instance;
            }
           
        }
    }

    static class Counter
    {
        public static int count = 0;
    }

    private static object _sync = new object();

    //private static void Main(string[] args)
    //{
    //    var threads = new Thread[5];

    //    for (int i = 0; i < threads.Length; i++)
    //    {
    //        threads[i] = new Thread(() =>
    //        {
    //            ////// problem
    //            //for (int j = 0; j < 1_000_000; j++)
    //            //{
    //            //    Counter.count = Counter.count + 1;
    //            //    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} => {Counter.count}");
    //            //}

    //            // Interlocked
    //            //for (int j = 0; j < 1_000_000; j++)
    //            //    Interlocked.Increment(ref Counter.count);

    //            // Monitor

    //            //for (int j = 0; j < 1_000; j++)
    //            //{
    //            //    Monitor.Enter(_sync);
    //            //    try
    //            //    {
    //            //        Counter.count++;
    //            //        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} => {Counter.count}");
    //            //    }
    //            //    finally
    //            //    {
    //            //        Monitor.Exit(_sync);
    //            //    }

    //            //}


    //            // Lock
    //            //lock (_sync)
    //            //{
    //            //    for (int j = 0; j < 1_000_000; j++)
    //            //    {
    //            //        Counter.count++;
    //            //        //Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} => {Counter.count}");
    //            //    }
    //            //}
    //        });
    //    }

    //    for (int i = 0; i < threads.Length; i++)
    //        threads[i].Start();

    //    for (int i = 0; i < threads.Length; i++)
    //        threads[i].Join();

    //    Console.WriteLine(Counter.count);

    //}
}