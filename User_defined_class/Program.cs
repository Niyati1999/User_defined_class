using System;

namespace User_defined_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //int rollno, semester;
            //string name;
            //Console.WriteLine("Enter rollno, name and semester :");
            //rollno = Convert.ToInt32(Console.ReadLine());
            //name = Console.ReadLine();
            //semester = Convert.ToInt32(Console.ReadLine());
            //Console.Write($"rollno = {rollno} \n name = {name} \n semester = {semester}");
            Student s1 = new Student();
            s1.rollno = 1;
            s1.name = "Niyati";
            s1.semester = 8;
            s1.printData();
        }
    }
}
