using System;

namespace OOP_Lab3
{
    partial class Time
    {
        // ПОЛЯ ====================================================
        private static int size;
        private readonly int objHash = size + 1;
        private const string month = "September";

        private int hour;
        private int minute;
        private int second;

        // СВОЙСТВА ================================================
        public int Hour
        {
            get => hour;
            set 
            {
                if(value >= 0 && value < 24)
                    hour = value;
                else
                    throw new Exception("Неверный формат времени.");
            }
        }

        public int Minute
        {
            get => minute;
            set
            {
                if (value >= 0 && value < 59)
                    minute = value;
                else
                    throw new Exception("Неверный формат времени.");
            }
        }

        public int Second
        {
            get => second;
            set
            {
                if (value >= 0 && value < 59)
                    second = value;
                else
                    throw new Exception("Неверный формат времени.");
            }
        }

        public string Month { get; }

        // КОНСТРУКТОРЫ ============================================
        static Time()
        {
            Console.WriteLine("Начата работа с классом \"Time_Class\"");
        }

        public Time()
        {
            Hour = 0;
            Minute = 0;
            Second = 0;

            Time.size++;
        }

        public Time(int hour = 0, int minute = 0, int second = 0)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;

            Time.size++;
        }

        private Time(int second)
        {
            hour = 0;
            minute = 0;
            this.Second = second;

            Time.size++;
        }

        // МЕТОДЫ ===================================================
        public override bool Equals(object obj)
        {
            Time tmp = obj as Time;
            if (tmp != null)
            {
                if (this.Hour == tmp.Hour && this.Minute == tmp.Minute && this.Second == tmp.Second)
                    return true;
                else    
                    return false;
            }

            throw new Exception("Невозможно преобразовать объект к типу Time_Class.");
        }

        public override int GetHashCode() => objHash;

        public override string ToString() => $"Hours: {Hour}, Minutes: {Minute}, Seconds: {Second}";

        public static void HoursSum(Time objOne, Time objTwo, out Time objOut)      // ничего лучше что-то не придумалось (главное, что суть ясна)
        {
            Time result = new Time(objOne.Hour + objTwo.Hour);
            objOut = result;
        }
    }
}


