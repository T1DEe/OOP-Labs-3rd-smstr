using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace OOP_Lab16
{
    public class Task7
    {
        private static int productCount;
        private static BlockingCollection<string> products;

        //–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

        private static void PutProuct()
        {
            // If you want to add more products per producer change this value
            int productsToPutCount = 1;

            for (int i = 0; i < productsToPutCount; i++, productCount++)
                products.Add("product" + productCount);
            Console.WriteLine($"Producer put product{productCount} to warehouse");
            //ShowWarehouse();
            products.CompleteAdding();
        }

        //–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

        private static void TakeProduct()
        {
            string productToTake;
            while (!products.IsCompleted)
            {
                if (products.TryTake(out productToTake))
                    Console.WriteLine($"Consumer takes a {productToTake} from warehouse");
                //ShowWarehouse();
            }
        }

        //–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

        // Doesnt work, with it to Console prints chaotic strings
        private static void ShowWarehouse()
        {
            Console.WriteLine("------------Products------------");
            foreach (var product in products)
                Console.WriteLine(product);
            Console.WriteLine("--------------------------------\n\n");
        }

        //–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

        public static void TaskMain()
        {
            productCount = 0;
            products = new BlockingCollection<string>();

            Task[] producers = new Task[]
            {
                    Task.Factory.StartNew(PutProuct),
                    Task.Factory.StartNew(PutProuct),
                    Task.Factory.StartNew(PutProuct),
                    Task.Factory.StartNew(PutProuct),
                    Task.Factory.StartNew(PutProuct)
            };
            Task[] consumers = new Task[]
            {
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct)
            };

            Task.WaitAll(producers.Concat(consumers).ToArray());
            foreach (var pr in producers)
                pr.Dispose();
            foreach (var con in consumers)
                con.Dispose();
            Console.WriteLine("\n==============================================\n");
        }

        //–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––
    }
}
