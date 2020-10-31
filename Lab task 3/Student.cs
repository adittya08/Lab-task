using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_task_3
{
    class Class1
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            obj.Name = "Fazla imam Dip";
            obj.Id = "19-40354-1";
            obj.Dept = "CSE";
            obj.Cgpa = "3.86";
            Console.WriteLine("My name is : " + obj.Name);
            Console.WriteLine("My id is : " + obj.Id);

            Console.WriteLine("My department is : " + obj.Dept);

        }
    }

    public class Student
    {
        private string name;
        private string id;
        private string dept;
        private string cgpa;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }


        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }

    }
}
