using System;

namespace OOP_Lab12
{
    class MainClass
    {
        public void TestMethod(int num, string str)
        {
            Console.WriteLine($"num: {num}, str: {str}");
            Console.WriteLine("Несвязный набор слов");
        }

        static void Main(string[] args)
        {
            Reflector reflector = new Reflector();
            Reflector.WriteClassToFile(reflector.ToString());

            Console.WriteLine("Methods: ");
            foreach (var q in Reflector.GetMethods(reflector.ToString()))
                Console.WriteLine("\t" + q.Name);


            Console.WriteLine("Fields and properties: ");
            foreach (var q in Reflector.GetFieldsAndProp(reflector.ToString()))
                foreach (var qq in q)
                    Console.WriteLine("\t" + qq.Name);


            Console.WriteLine("Interfaces: ");
            foreach (var q in Reflector.GetInterface(reflector.ToString()))
                Console.WriteLine("\t" + q.Name);


            Console.WriteLine();
            MainClass main = new MainClass();
            Reflector.PrintMethodByName(main.ToString(), typeof(int));

            Reflector.WriteClassToFile(main.ToString());
            Reflector.ExecuteMethod(main.ToString(), "TestMethod");
        }
    }
}
