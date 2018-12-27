using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Типы 

            // a. Определите переменные всех возможных примитивных типов С# и проинициализируйте их.
            bool bl = true;
            byte bt = 1;
            sbyte sbt1 = -101;
            short shrt = 1;
            ushort ushrt = 1;
            uint umun = 10;
            long lng = -10;
            ulong ulng = 10;
            char chr1 = 'a';
            object obj = "hello code";

            int num1 = 12;
            int num2 = 13;
            int num3 = 14;
            int num4 = 15;
            int num5 = 16;
        
            float flt1 = 12.3F;
            float flt2 = 13.3F;
            float flt3 = 14.3F;
            float flt4 = 15.3F;
            float flt5 = 16.3F;

            double dbl1 = 1.5;
            double dbl2 = 2.5;
            double dbl3 = 3.5;
            double dbl4 = 4.5;
            double dbl5 = 5.5;


            // Выполните 5 операций явного и 5 неявного приведения.
            // явные
            num1 = (int)flt1;
            flt1 = (float)dbl1;
            num2 = (int)dbl2;
            dbl1 = (double)num3;
            flt2 = (float)dbl4;

            // неявные 
            flt3 = num3;
            dbl2 = flt4;
            dbl3 = chr1;
            dbl4 = num3;

            // c. Выполните упаковку и распаковку значимых типов.
            Object Something = num1;
            num1 = (int)Something;

            // d. Продемонстрируйте работу с неявно типизированнй переменной.
            var num6 = 3;
            Console.WriteLine(num6.GetType().ToString());

            // e. Продемонстрируйте пример работы с Nullable переменной.
            int? i = null;


         // 2) Строки

            string str1 = "I am str1";
            string str2 = "I am string";
            string str3 = "I am str3";
            string str4 = "I am str4";
            string str5 = "I am str5";

            char[] gse = str2.ToArray();
            foreach (char item in gse)
            { Console.WriteLine(item); }

            float abc = 5;
            Convert.ToInt16(abc);
            

            // a.Объявите строковые литералы.Сравните их.
            if (str1 == str2)
            {
                Console.WriteLine("Строки равны");
            }
            else
            {
                Console.WriteLine("Строки не равны");
            }

            // b.Создайте три строки на основе String. Выполните: сцепление+, копирование+, выделение подстроки+, 
            //      разделение строки на слова, вставки подстроки в заданную позицию+, удаление заданной подстроки+.
            str4 = str1 + " " + str2;
            str4 = str4.Insert(3, "VAR");
            string[] words = str5.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 
            str4 = str4.Remove(0, 2);
            str4 = str1.Substring(2, 4);
            str4.Contains("str");

            // c.Создайте пустую и null строку.Продемонстрируйте что можно выполнить с такими строками
            string str6 = "";
            string str7 = null;

            if (str7 == null)
            {
                Console.WriteLine("Поле не заполнено");
            }

            // d.Создайте строку на основе StringBuilder.Удалите определенные позиции и добавьте новые символы в начало и конец строки.
            StringBuilder myStringBuilder = new StringBuilder("Хахахахах");
            myStringBuilder.Remove(0, 2);
            myStringBuilder.Append(". I'm added part");
            myStringBuilder.Insert(0, "Hi. ");
            myStringBuilder.Insert(myStringBuilder.Length, "!");
            Console.WriteLine(myStringBuilder);


            // 3) Массивы
            //a.Создайте целый двумерный массив и выведите его на консоль в отформатированном виде(матрица). 
            int n = 3;
            int m = 3;
            int[,] mas = new int[n, m];

            Random rand = new Random();

            for (int c = 0; c < n; c++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[c, j] = rand.Next(1, 9);
                }                   
            }
               
            for (int c = 0; c < n; c++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(String.Format("{0,3}", mas[c, j]));
                Console.WriteLine();
            }
            Console.WriteLine();

            // b.Создайте одномерный массив строк. Выведите на консоль его содержимое, длину массива. 
            //            Поменяйте произвольный элемент(пользователь определяет позицию и значение).
            int[] array = new int[5] { 1, 2, 3, 4, 5 };

            foreach (int item in array)
            {
                Console.Write("{0} ", item);       
            }
            Console.WriteLine();

            Console.WriteLine("Введите индекс элемента и новое значение");
            int index = -1;
            while (index < 0 || index > array.Length)
            {
                index = int.Parse(Console.ReadLine());
            }
            int value = int.Parse(Console.ReadLine());
            array[index - 1] = value;

            foreach (int item in array)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            // d.Создайте неявно типизированные переменные для хранения массива и строки
            var someArray = array;
            var someString = str1;

            // 4) Кортежи
            // a. Задайте кортеж из 5 элементов с типами int, string, char, string, ulong.
            // b.Сделайте именование его элементов.
            (int, string, char, string, ulong) tuple = (a: 4, b: "Tom", c: 'a',d: "string",e: 56);

            // c.Выведите кортеж на консоль целиком и выборочно(1, 3, 4  элементы)
            Console.WriteLine("{0} {1} {2} {3} {4}", tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);
            Console.WriteLine("{0} {1} {2}", tuple.Item1, tuple.Item3, tuple.Item4);

            // d.Выполните распаковку кортежа в переменные
            (var a, var b, var v, var d ,var e) = (tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);

            // e.Сравните два кортежа.
            (int, string, char, string, ulong) tuple2 = (a: 4, b: "Tom", c: 'a', d: "string", e: 56);

            if (tuple.Equals(tuple2))
            {
                Console.WriteLine("Кортежи равны!");
            }

            // 5) Создайте локальную функцию в main и вызовите ее. Формальные параметры функции – массив целых и строка. 
                                //Функция должна вернуть кортеж, содержащий: максимальный и минимальный элементы массива,
                                                                         //сумму элементов массива и первую букву строки.
            (int, int, char) myFunction (int[] arrayOfInt, string string1)
            {
                (int, int, char) tuple3 = (arrayOfInt.Min(), arrayOfInt.Max(), string1.First());

                return tuple3;
            }

            myFunction(array, str5);


            Console.ReadKey();
        }
    }
}
