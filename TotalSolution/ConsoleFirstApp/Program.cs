using System;
using System.Collections.Generic;

namespace ConsoleFirstApp
{
    class Student
    {
        public string name;
        public int grade;

        public static void kkk()
        {
            Console.WriteLine("안녕하세요");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //주석
            Console.WriteLine("Second print");

            Student aStudent = new Student() { grade = 1, name = "연습용" };
            Student aStudent1 = new Student();
            aStudent1.grade = 1;

            List<Student> list = new List<Student>();
            list.Add(new Student() { name = "아아", grade = 1 });
            list.Add(aStudent);
            Student.kkk();
        }
    }
}
