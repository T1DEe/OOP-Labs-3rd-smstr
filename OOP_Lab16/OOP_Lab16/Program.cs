using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;


namespace OOP_Lab16
{
    class Program
    {
        private const long maxNum = 100000;

        private static CancellationTokenSource source = new CancellationTokenSource();
        private static CancellationToken token = source.Token;


        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task5();
            Task6();
            Task7.TaskMain();

            Console.WriteLine("================================================\n");
        }
        //=======================================================================================
        public static void SearchSimpleNumber()
        {
            for (long i = 2; i <= maxNum; i++)
            {
                if (isSimpleNumber(i))
                    Console.Write(i + ", ");
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("See you soon\n");
                    return;
                }
            }
        }
        //=======================================================================================
        private static bool isSimpleNumber(long num)
        {
            for (long i = 2; i <= (num / 2); i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        //=======================================================================================
        public static void Task1()
        {
            int iteration = 3;
            Stopwatch stopwatch = new Stopwatch();
            while (iteration > 0)
            {
                stopwatch.Start();
                Task task = Task.Factory.StartNew(SearchSimpleNumber);
                Console.WriteLine($"\nЗадача {iteration}. ID: {task.Id.ToString()}");
                Console.WriteLine($"\nЗадача {iteration}. статус: {task.Status.ToString()}");
                task.Wait();
                stopwatch.Stop();
                Console.WriteLine($"\nВремя выполнения задачи {iteration}: {stopwatch.Elapsed.TotalMilliseconds.ToString()}\n");
                stopwatch.Reset();
                iteration--;
                Console.WriteLine("--------------------");
            }
            Console.WriteLine("================================================\n");
        }
        //=======================================================================================
        public static void Task2()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Task task = Task.Factory.StartNew(SearchSimpleNumber);
            Console.WriteLine($"\nID задачи: {task.Id.ToString()}");
            Console.WriteLine($"\nСтатус задачи: {task.Status.ToString()}");

            Console.WriteLine("q - для выхода ");
            if (Console.ReadKey().KeyChar == 'q')
                source.Cancel();

            task.Wait();
            stopwatch.Stop();
            Console.WriteLine($"\nВремя выполнения задачи: {stopwatch.Elapsed.TotalMilliseconds.ToString()}\n");
            Console.WriteLine("================================================\n");
        }
        //=======================================================================================
        const int capacity = 100;
        const int density = 1000;
        const int weight = 6000;

        public static int GetWeight() => capacity * density;
        public static int GetDensity() => weight / capacity;
        public static int GetCapacity() => weight / density;

        public static async void Task3()
        {
            Task<int> task1 = Task.Factory.StartNew(GetWeight);
            Task<int> task2 = Task.Factory.StartNew(GetDensity);
            Task<int> task3 = Task.Factory.StartNew(GetCapacity);

            await task1.ContinueWith((firstTask) => Console.WriteLine($"\nРезультат GetWeight: {firstTask.Result}"));
            await task2.ContinueWith((secondTask) => Console.WriteLine($"\nРезультат GetDensity: {secondTask.Result}"));
            await task3.ContinueWith((thirdTask) => Console.WriteLine($"\nРезультат GetCapacity: {thirdTask.Result}"));

            task3.ContinueWith((thirdTask) => Console.WriteLine($"\nРезультат GetCapacity с GetAwaiter(): {thirdTask.Result}")).GetAwaiter();
            task2.ContinueWith((secondTask) => Console.WriteLine($"\nРезультат GetDensity с GetAwaiter().GetResult(): {secondTask.Result}")).GetAwaiter().GetResult();
            Console.WriteLine("================================================\n");
        }
        //=======================================================================================
        public static void Task5()
        {
            const int arrSize = 1000000;
            const int arrCount = 10;
            Stopwatch stopwatch = Stopwatch.StartNew();
            Parallel.For(0, arrCount, (Count) =>
            {
                int[] arr = new int[arrSize];
                Parallel.ForEach(arr, (el) =>
                {
                    el = arrCount * arrCount;
                });
            });
            stopwatch.Stop();
            Console.WriteLine("\nTime with Parallel.For, Parallel.ForEach: " + stopwatch.Elapsed.Milliseconds.ToString());
            stopwatch.Restart();
            for (int i = 0; i < arrCount; i++)
            {
                int[] arr = new int[arrSize];
                for (int j = 0; j < arr.Length; j++)
                    arr[j] = arrCount * arrCount;
            }
            stopwatch.Stop();
            Console.WriteLine("\nTime with two for operators: " + stopwatch.Elapsed.Milliseconds.ToString());
            Console.WriteLine("================================================\n");
        }
        //=======================================================================================
        public static void Task6()
        {
            Parallel.Invoke(Task6Handler, Task6Handler, Task6Handler);
            Console.WriteLine("================================================\n");
        }
        private static void Task6Handler()
        {
            int[] arr = new int[100000];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = i * i;
            Console.WriteLine("\nParallel.Invoke закончил работу.\n");
        }
        //=======================================================================================
    }
}