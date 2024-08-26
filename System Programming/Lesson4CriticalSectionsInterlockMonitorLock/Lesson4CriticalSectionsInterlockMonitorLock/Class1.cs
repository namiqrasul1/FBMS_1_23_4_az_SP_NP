namespace Lesson4CriticalSectionsInterlockMonitorLock
{
    class Car
    {
        public string Vendor { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
    internal class Class1
    {
        public static List<Car> Cars { get; set; } = [];
        private static object _sync = new object(); 
        public static void ReadFromFile(string filePath)
        {
            
            lock (_sync)
            {
                // file'dan oxumaq
                // list'e append
                Car car = new();
                Cars.Add(car);
            }
        
        }
        static void Main(string[] args)
        {
            Thread th = new Thread(() => { ReadFromFile("a.txt"); });  // 3000000
            Thread th1 = new Thread(() => { ReadFromFile("b.txt"); }); // 1000000
            th.Start();
            th1.Start();

        }
    }
}
