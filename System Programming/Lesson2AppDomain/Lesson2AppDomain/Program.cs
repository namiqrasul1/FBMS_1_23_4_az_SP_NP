using System;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace Lesson2AppDomain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var domain = AppDomain.CreateDomain("BabatDomain");

            //var type = typeof(Virus);
            ////Console.WriteLine(type.FullName);
            ////Console.WriteLine(type.Name);
            ////Console.WriteLine(type.Assembly.FullName);

            //var obj = domain.CreateInstance(type.Assembly.FullName, type.FullName);

            //AppDomain.Unload(domain);
            //Console.ReadLine();


            //PermissionSet perm = new PermissionSet(System.Security.Permissions.PermissionState.None);

            //perm.AddPermission(new FileIOPermission(PermissionState.None));
            //perm.AddPermission(new FileIOPermission(FileIOPermissionAccess.NoAccess, "C://"));

            //var appDomainSetup = new AppDomainSetup();
            //appDomainSetup.ApplicationBase = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

            //AppDomain appDomain = AppDomain.CreateDomain("BabatDomain", null, appDomainSetup, perm);

            //AppDomain.Unload(appDomain);


            Thread t = new Thread(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine('x');
                    Thread.Sleep(100);
                }
            });

            t.Start();


            Console.ReadKey();
            t.Suspend();
            Console.ReadKey();
            t.Resume();

            Console.ReadKey();
            t.Abort();
        }
    }

    class Virus
    {
        public Virus()
        {
            Console.WriteLine("Salam, men hackerem, geldim ogurluga");
        }

        ~Virus()
        {
            Console.WriteLine("Sagol, men ogurladim gedirem");
        }
    }
}
