using System;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Text;
using System.Threading;

namespace Lesson3AsynchronousMethodThreadPool
{
    internal class Program
    {
        #region Asynchronous Method

        //delegate void SomeDelegate();
        //static void DoSomething()
        //{
        //    Console.WriteLine($"{Thread.CurrentThread.Name} {Thread.CurrentThread.ManagedThreadId} {Thread.CurrentThread.IsThreadPoolThread} {Thread.CurrentThread.IsBackground}");
        //    Thread.Sleep(1000);
        //    Console.WriteLine("DoSomething");
        //}
        //static void Main(string[] args)
        //{
        //    //Thread t = new Thread(DoSomething);
        //    //Thread t1 = new Thread(DoSomething);
        //    //t.Name = "Miro";
        //    //t1.Name = "Logo";
        //    //Thread.CurrentThread.Name = "Main";
        //    //t.Start();
        //    //t1.Start();

        //    //SomeDelegate del = DoSomething;
        //    //del.BeginInvoke(null, null);


        //    //DoSomething();

        //    //SomeDelegate del = DoSomething;

        //    //IAsyncResult result = del.BeginInvoke(null, null);
        //    //del.EndInvoke(result);
        //}

        #endregion

        #region ThreadPool

        //private static void AsyncMethod(object state)
        //{
        //    Console.WriteLine(state.ToString());
        //    Console.WriteLine($"Worker Thread Id: {Thread.CurrentThread.ManagedThreadId} IsThreadPoolThread: {Thread.CurrentThread.IsThreadPoolThread}");
        //}

        //static void Main(string[] args)
        //{
        //    ThreadPool.QueueUserWorkItem(AsyncMethod, "Miro");
        //    Console.ReadKey();
        //}


        #endregion

        #region Thread vs ThreadPool
        //static void UseThread(int operation)
        //{
        //    Console.WriteLine("Thread");

        //    using(var countdown = new CountdownEvent(operation))
        //    {
        //        for (int i = 0; i < operation; i++)
        //        {
        //            var thread = new Thread(() =>
        //            {
        //                Console.Write($"{Thread.CurrentThread.ManagedThreadId} ");
        //                Thread.Sleep(100);
        //                countdown.Signal();
        //            });
        //            thread.Start();
        //        }
        //        countdown.Wait();
        //        Console.WriteLine();
        //    }
        //}

        //static void UseThreadPool(int operation)
        //{
        //    Console.WriteLine("ThreadPool");
        //    using(var countdown = new CountdownEvent(operation))
        //    {
        //        for(int i = 0;i < operation; i++)
        //        {
        //            ThreadPool.QueueUserWorkItem((e) =>
        //            {
        //                Console.Write($"{Thread.CurrentThread.ManagedThreadId} ");
        //                Thread.Sleep(100);
        //                countdown.Signal();
        //            });
        //        }
        //        countdown.Wait();
        //        Console.WriteLine();
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    //int op = 500;
        //    //var stopwatch = new Stopwatch();
        //    //stopwatch.Start();
        //    //UseThread(op);
        //    //stopwatch.Stop();
        //    //Console.WriteLine($"Milliseconds: {stopwatch.ElapsedMilliseconds}");
        //    //stopwatch.Restart();
        //    //UseThreadPool(op);
        //    //stopwatch.Stop();
        //    //Console.WriteLine($"Milliseconds: {stopwatch.ElapsedMilliseconds}");


        //    //ThreadPool.GetAvailableThreads(out int worker, out int comp);
        //    //Console.WriteLine(worker);
        //    //ThreadPool.GetMaxThreads(out int worker, out int comp);
        //    //Console.WriteLine(worker);
        //}
        #endregion

        #region CancelationToken

        private static string Download(CancellationToken cancellationToken)
        {
            Console.WriteLine("Downloading....");
            for (int i = 5; 0 < i; i--)
            {
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine($"Downloading. Please Wait {i} seconds");
                try
                {
                    cancellationToken.ThrowIfCancellationRequested();
                }
                catch
                {
                    Console.WriteLine("Downloading canceled");
                    throw;
                }

                //if( cancellationToken.IsCancellationRequested ) { }

            }
            Console.WriteLine("Downloading ended successfully");
            return "downloaded file";
        }

        private static string Encrypt(string needToEncrypt, int key, CancellationToken cancellationToken)
        {
            Console.WriteLine("Encrypting...");
            var sb = new StringBuilder();
            for (int i = 0; i < needToEncrypt.Length; i++)
            {
                sb.Append(needToEncrypt[i] ^ key);

                cancellationToken.ThrowIfCancellationRequested();
            }
            Console.WriteLine("Encryption ended suc");
            return sb.ToString();
        }

        private static void Upload(string uploadFile, CancellationToken cancellationToken)
        {
            Console.WriteLine("Uploading...");
            cancellationToken.ThrowIfCancellationRequested();
            Console.WriteLine("file uploaded");
        }

        static void DoSomething(CancellationToken token)
        {
            string str;
            try
            {
                str = Download(token);
                var enc = Encrypt(str, 42, token);
                Upload(enc, token);
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine("work canceled");
            }
        }


        static void Main(string[] args)
        {
            using (var cts = new CancellationTokenSource())
            {
                ThreadPool.QueueUserWorkItem((o) => { DoSomething(cts.Token); });
                Thread.Sleep(500);
                cts.Cancel();
                Console.ReadKey();
            }
        }
        #endregion
    }
}
