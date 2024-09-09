using Lesson8ParallelPlinq.Data;
using Lesson8ParallelPlinq.Fakers;
using Lesson8ParallelPlinq.Models;
using System.Diagnostics;
using System.Linq.Expressions;

// Parallel 
// PLINQ

var students = InitalizeStudents.GenerateStudents(2000);

//Stopwatch sw1 = new Stopwatch();
//sw1.Start();
//foreach (var student in students)
//{
//    student.Group = "New Group";
//    await Task.Delay(10);
//}
//sw1.Stop();
//Console.WriteLine(sw1.ElapsedTicks);

//Stopwatch sw = new();

//Task t = new(async () =>
//{
//    for (int i = 0; i < students.Count / 2; i++)
//    {
//        students[i].Group = "New Group";
//        await Task.Delay(10);
//    }
//});

//Task t1 = new(async () =>
//{
//    for (int i = students.Count / 2; i < students.Count; i++)
//    {
//        students[i].Group = "New Group";
//        await Task.Delay(10);
//    }
//});


//sw.Start();
//t.Start();
//t1.Start();
//await Task.WhenAll(t, t1);

//sw.Stop();


//Console.WriteLine(sw.ElapsedTicks);

//Stopwatch sw = new();
//sw.Start();

//Parallel.ForEach(students, async (student) =>
//{
//    await Console.Out.WriteLineAsync($"{Thread.CurrentThread.ManagedThreadId} {Thread.CurrentThread.IsThreadPoolThread}");
//    student.Group = "New Group";
//    await Task.Delay(10);
//});

//sw.Stop();
//Console.WriteLine(sw.ElapsedTicks);


//Parallel.For(0, students.Count, async (i) =>
//{
//    await Console.Out.WriteLineAsync(i.ToString());
//});
//Console.WriteLine();


// 310292252 main thread
// 15314     2 tasks
// 110443    Parallel


//Parallel.Invoke(
//    () => { Console.WriteLine("Salam 1"); },
//    () => { Console.WriteLine("Salam 2"); },
//    () => { Console.WriteLine("Salam 3"); },
//    () => { Console.WriteLine("Salam 4"); },
//    () => { Console.WriteLine("Salam 5"); },
//    () => { Console.WriteLine("Salam 6"); }
//    );


//int i = 0;

//Parallel.ForEach(students, student => { Interlocked.Increment(ref i); });
//Console.WriteLine(i);

//for(int i = 0; i < 10; i++)
//{
//    int tt = i;
//    Thread t = new(() => Console.WriteLine(tt));
//    t.Start();
//}

// Data Source=STHQ0118-01;Initial Catalog=Library;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False


using var context = new LibraryContext();

var authors = context.Authors.AsParallel().Where(a => { Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}"); return true; }).ToList();
Console.WriteLine(authors.Count);

//Func<Author, bool>? func = (a) => { Console.WriteLine("s"); return true; };
//Expression<Func<Author, bool>>? expression = (a) => {  return true; }; // 1 setirlik

void AddStudent(AddStudentDto model)
{
    
    context.Students.Add(model);
}