using System;
namespace OOP_Lab4
{
    public class Company
    {
        string Name { get; set; }
        int Year { get; }
        string DirectorsName { get; set; }

        public Company(string name, int year, string directorsName)
        {
            Name = name;
            Year = year;
            DirectorsName = directorsName;
        }

        public void Show()
        {
            Console.WriteLine($"{Name}, {Year}, {DirectorsName}");
        }
    }
}
