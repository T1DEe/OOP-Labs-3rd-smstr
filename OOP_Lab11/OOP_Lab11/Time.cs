using System;

namespace OOP_Lab11
{
    class Time
    {
        private int hour;
        private int minute;
        private int second;

        //Свойства
        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                if (value >= 0 && value < 24)
                    hour = value;
                else
                    throw new Exception("Неверный формат времени.");
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
                if (value >= 0 && value < 60)
                    minute = value;
                else
                    throw new Exception("Неверный формат времени.");
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
                    second = value;
                else
                    throw new Exception("Неверный формат времени.");
            }
        }

        //Конструкторы
        public Time()
        {
            this.Hour = 0;
            this.Minute = 0;
            this.Second = 0;
        }

        public Time(int hour)
        {
            this.Hour = hour;
            this.Minute = 0;
            this.Second = 0;
        }


        public Time(int hour, int minute)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = 0;
        }

        public Time(int hour, int minute, int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }

        //Методы
        public override bool Equals(object obj)
        {
            Time time = obj as Time;
            if (this.hour == time.hour && this.minute == time.minute && this.second == time.second)
                return true;
            else
                return false;
        }

    }
}


