using System;
namespace OOP_Lab10
{
    public class Student
    {
        public string Name { get; }
        public int Course { get; set; }


        public Student()
        {
            Name = "Вася";
            Course = 1;
        }

        public Student(string name, int course)
        {
            Name = name;
            Course = course;
        }
    }
}
