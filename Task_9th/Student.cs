using System;
using System.Collections.Generic;
using System.Text;

namespace Task_9th
{
    class Student
    {
        private string name;
        private string id;
        private string dept;
        private float cgpa;

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
        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }


        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }
        public Student()
        {
            name = "Adittya Chakraborty";
            id = "18-38693-3";
            dept = "CSE";
            cgpa = 3.86f;

        }
        public Student(string name, string id, string department, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.dept = department;
            this.cgpa = cgpa;
        }
        public void showInfo()
        {
            Console.WriteLine("The name of the student is " + Name + " " + ", his ID is " + id + " " + " and his department is " + Dept + " " + " and his CGPA is " + Cgpa);
        }
    }
}
