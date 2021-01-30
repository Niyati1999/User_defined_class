using System;
using System.Collections.Generic;
using System.Text;

namespace User_defined_class
{
    class Student
    {
        public int rollno, semester;
        public string name;
        public void printData()
        {
            Console.Write($"rollno = {rollno}  \n name = {name} \n semester = {semester}");
        }
    }
}
