using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    partial class Time_Class : Object
    {
        public static int size = 0;

        private int hour;
        private int minute;
        private int second;
        static readonly int id = size + 1;
        const string month = "september";

        //Свойства
        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                if(value >= 0 && value < 24)
                {
                    hour = value;
                }
                else
                {
                    Console.WriteLine("Неверный формат времени. Установлено как 0.");
                    hour = 0;
                }
            }
        }

        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value >= 0 && value < 59)
                {
                    minute = value;
                }
                else
                {
                    Console.WriteLine("Неверный формат времени. Установлено как 0.");
                    minute = 0;
                }
            }
        }

        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value >= 0 && value < 59)
                {
                    second = value;
                }
                else
                {
                    Console.WriteLine("Неверный формат времени. Установлено как 0.");
                    second = 0;
                }
            }
        }

        //Конструкторы
        public Time_Class()
        {
            Hour = 0;
            Minute = 0;
            Second = 0;
        }

        public Time_Class(int hour)
        {
            this.Hour = hour;
            Minute = 0;
            Second = 0;
        }


        public Time_Class(int hour, int minute = 0, int second = 0) : this(hour)
        {
            this.Minute = minute;
            this.Second = second;
        }

        static Time_Class()
        {
            Console.WriteLine("Начата работа с классом \"Time_Class\"");
            Time_Class.size++;
        }

        private Time_Class(float second)
        {
            hour = 0;
            minute = 0;
            this.second = (int)second;
        }

        //Методы
        public static void PrivateConst()
        {
            Time_Class prv = new Time_Class(10F);
        }

        public override bool Equals(object obj)
        {
            return true;
        }

        public int SumOfHourTime(ref Time_Class a, ref Time_Class b, out Time_Class some)
        {
            some = a;
            
            return a.hour + b.hour;
        }
    }
}


