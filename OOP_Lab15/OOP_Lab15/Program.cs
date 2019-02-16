using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Reflection;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace OOP_Lab15
{
    class Program
    {
        private static EventWaitHandle waitHandle = new ManualResetEvent(initialState: true);
        private static object locker = new object();
        private static string oddAbdEvenNum = "";
        private static void DomainUnloadEvent(object sender, EventArgs e) => Console.WriteLine("Домен выгружен из процесса.");
        private static void DomainAssemlyLoadEvent(object sender, AssemblyLoadEventArgs args) => Console.WriteLine("Сборка загружена.");

        static void Main(string[] args)
        {
            //Console.WriteLine("Задание 1");
            //var processes = Process.GetProcesses();
            //foreach (var item in processes)
            //{
            //    Console.WriteLine("NameOfProcess: " + item.ProcessName);
            //    Console.WriteLine("IdOfProcess: " + item.Id);
            //    Console.WriteLine("PriorityOfProcess: " + item.BasePriority);
            //    Console.WriteLine("TimeOfProcess: " + item.StartTime.ToString());
            //    Console.WriteLine("WorkingTime: " + item.TotalProcessorTime);
            //    Console.WriteLine("\n");
            //}
            //Console.WriteLine("–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");

            Console.WriteLine("Задание 2");
            CurrentDomainInfo();
            CreateDomain();
            Console.WriteLine("–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");

            Console.WriteLine("Задание 3");
            int number;
            while (true)
            {
                Console.Write("Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out number))
                    break;


                Console.WriteLine("Try again");
            }

            Thread myThread = new Thread(NumbersToConsole);
            myThread.Name = "NumberToConsole";
            Console.WriteLine(myThread.ThreadState.ToString());

            myThread.Start(number);
            Console.WriteLine("Thread status: " + myThread.ThreadState.ToString());
            Thread.Sleep(1);

            myThread.Suspend();
            Console.WriteLine("Thread status: " + myThread.ThreadState.ToString());

            myThread.Abort();
            Console.WriteLine("Thread status: " + myThread.ThreadState.ToString());

            Console.WriteLine("–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");

            Console.WriteLine("Задание 4");
            Thread oddThread = new Thread(OddAndEvenNumbersToConsole);
            oddThread.Name = "oddThread";
            oddThread.Priority = ThreadPriority.Lowest;
            Thread evenThread = new Thread(OddAndEvenNumbersToConsole);
            evenThread.Name = "evenThread";
            evenThread.Priority = ThreadPriority.Lowest;

            // true = odd numbers, false = even numbers
            ValueTuple<int, bool> oddnum = (number, true);
            ValueTuple<int, bool> evennum = (number, false);

            oddThread.Start(oddnum);
            evenThread.Start(evennum);

            // Waiting for end of processes
            Thread.Sleep(2000);
            Console.WriteLine("–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");

            Console.WriteLine("Задание 5");
            TimerCallback tm = new TimerCallback(TimerMethod);
            Timer timer = new Timer(tm, 10, 0, 2000);

            Console.ReadLine();
            Console.WriteLine("–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
        }

        // ––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––
        // ––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

        public static void CurrentDomainInfo()
        {
            AppDomain domain = AppDomain.CurrentDomain;
            Console.WriteLine("Domain id: " + domain.Id);
            Console.WriteLine("Domain name: " + domain.FriendlyName);
            Console.WriteLine("Domain base directory: " + domain.BaseDirectory);

            Assembly[] assemblies = domain.GetAssemblies();
            Console.WriteLine("Assemblies:");
            foreach (var item in assemblies)
                Console.WriteLine("Name: " + item.GetName().Name);
        }

        // ––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

        public static void CreateDomain()
        {
            AppDomain domain = AppDomain.CreateDomain("myDomain");
            domain.AssemblyLoad += DomainAssemlyLoadEvent;
            domain.DomainUnload += DomainUnloadEvent;

            // OOP_Lab15/bin/debug/
            //domain.Load(new AssemblyName("System.Data"));
            Assembly[] assemblies = domain.GetAssemblies();
            foreach (var item in assemblies)
            {
                Console.WriteLine("Name: " + item.GetName().Name);
                Thread.Sleep(50);
            }

            AppDomain.Unload(domain);
        }

        // ––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

        static void NumbersToConsole(object num)
        {
            int n = (int)num;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("My thread: " + i);
                Thread.Sleep(0);
            }
        }

        // ––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

        static void TimerMethod(object count)
        {
            int n = (int)count;
            for (int i = 1; i < 9; i++, n++)
                Console.WriteLine("Timer " + (n * i));
        }

        // ––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

        public static void OddAndEvenNumbersToConsole(object num)
        {
            // true = odd numbers, false = even numbers
            lock (locker)
            {
                ValueTuple<int, bool> n = (ValueTuple<int, bool>)num;
                for (int i = 0; i < n.Item1; i++)
                {
                    if (i % 2 == 1 && n.Item2)
                    {
                        string str = "Odd Thread: " + i + '\n';
                        Console.Write(str);
                        oddAbdEvenNum += str;
                        //Thread.Sleep(0);
                        //Thread.Sleep(100);
                    }
                    if (i % 2 == 0 && !n.Item2)
                    {
                        string str = "Even Thread: " + i + '\n';
                        Console.Write(str);
                        oddAbdEvenNum += str;
                        //Thread.Sleep(0);
                        //Thread.Sleep(100);
                    }
                }
            }
        }

        // ––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––
    }
}