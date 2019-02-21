using System;
namespace OOP_Lab4
{
    public class Owner
    {
        private readonly int id;
        private readonly string fio;

        public Owner(int id, string fio)
        {
            this.id = id;
            this.fio = fio;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Owner – ID: {id}, FIO: {fio}.");
        }
    }
}


