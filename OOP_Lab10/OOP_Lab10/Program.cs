using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace OOP_Lab10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ArrayList arrayList1 = new ArrayList();

            Random rnd = new Random();
            for (int i=0; i<5; i++)
                arrayList1.Add(rnd.Next());

            arrayList1.Add("aaa");
            arrayList1.Add(new Student());
            arrayList1.Remove("aaa");


            foreach(var item in arrayList1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Count of arrayList1: {arrayList1.Count}");

            Console.WriteLine();
            //––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––
            Stack<double> stack1 = new Stack<double>();

            stack1.Push(3D);
            stack1.Push(5D);
            stack1.Push(1D);
            stack1.Push(9D);

            foreach (double item in stack1)
                Console.WriteLine(item);

            Console.WriteLine("Сколько эл-ов удалить из стека?");
            int input = int.Parse(Console.ReadLine());
            if (input < stack1.Count)
            {
                for (int i = 0; i < input; i++)
                    stack1.Pop();
            }
            else
                Console.WriteLine("Выход за границы стека.");


            Console.WriteLine();
            //––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

            LinkedList<double> linkedList1 = new LinkedList<double>();
            foreach(double item in stack1)
            {
                linkedList1.AddLast(item);
                Console.WriteLine(item);
            }

            //––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––
            Agency a = new Agency(2);
            a[0] = new Vehicle("sad");
            a[1] = new Vehicle("bad");

            Agency b = new Agency(2);
            a[0] = new Vehicle("good");
            a[1] = new Vehicle("null");


            Stack<Agency> stack2 = new Stack<Agency>();
            stack2.Push(a);
            stack2.Push(b);

            //foreach(Agency item in stack2)
                //item.Print();


            LinkedList<Agency> linkedList2 = new LinkedList<Agency>();
            linkedList2.AddLast(a);
            linkedList2.AddLast(b);

            //foreach (Agency item in linkedList2
            //    item.Print();


            //––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

            ObservableCollection<Student> students = new ObservableCollection<Student>
            {
                new Student("Bill", 2),
                new Student("Tom", 3),
                new Student("Max", 1)
            };

            students.CollectionChanged += Students_CollectionChanged;

            students.Add(new Student("Lox", 2));
        }

        private static void Students_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch(e.Action)
            {
                case NotifyCollectionChangedAction.Add:     //если объект добавляется
                {
                        Student newStudent = e.NewItems[0] as Student;
                        Console.WriteLine("Зачислен студент: {0}", newStudent.Name);
                        break;
                }
                case NotifyCollectionChangedAction.Remove:      //если объект удаляется
                    {
                        Student oldStudent = e.OldItems[0] as Student;
                        Console.WriteLine("Отчислен студент(таму шо учиться нужно было): {0}", oldStudent.Name);
                        break;
                    }
            }
        }
    }
}
