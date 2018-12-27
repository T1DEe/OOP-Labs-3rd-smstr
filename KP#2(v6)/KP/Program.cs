using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    //––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

    class SuperList<T>
    {
        List<T> list = new List<T>();

        public void Push(T value)
        {
            list.Add(value);
        }

        public T Search(T value)
        {
            try
            {
                if (list.Contains(value))
                    return value;
                else
                    throw new Exception($"Error: Значение {value} отсутствует в коллекции");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return value;
        }
    }

    //––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

    class Match
    {
        public delegate void matchDelegate(Fan fanOne, Fan fanTwo);
        public event matchDelegate GoalEvent;

        public void Goal(Fan fanOne, Fan fanTwo)
        {
            Console.WriteLine("Был забит гол. Что скажут фанаты?!");
            GoalEvent(fanOne, fanTwo);
        }
    }
    class Fan
    {
        public void Goal()
        {
            Console.WriteLine("ГОЛ!!!!");
        }
    }
    //––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––



    class MainClass
    {
        public static void Main(string[] args)
        {

            SuperList<string> superList = new SuperList<string>();
            superList.Push("first");
            if (superList.Search("first") == "first")
                Console.WriteLine("Значение first содержится в коллекции");

            superList.Search("second");
            Console.WriteLine();

            //––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

            string[] strArray = { "Artemy", "Is", "The", "Best" };

            var sortedArray = strArray.Where(word => word[0] == 'B' && word.Length == 4);
            foreach (string item in sortedArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

            Fan fanOne = new Fan();
            Fan fanTwo = new Fan();
            Match match = new Match();

            match.GoalEvent += (Fan one, Fan two) =>
            {
                one.Goal();
                two.Goal();
            };

            match.Goal(fanOne, fanTwo);
        }
    }
}

