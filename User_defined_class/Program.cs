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
            Square s2 = new Square();
            s2.length = 10;
            int ans1 = s2.area();
            int ans2 = s2.perimeter();
            Console.Write($"area = {ans1} \n perimeter = {ans2} \n");
            Square s3 = new Square();
            s3.length = 5;
            int ans3 = s3.area();
            int ans4 = s3.perimeter();
            Console.Write($"area {ans3} \n perimeter = {ans4} \n");
            s2 = s3;
            Console.WriteLine(s2.length);
            Console.WriteLine(s2.area());
            Console.WriteLine(s2.perimeter());
            s2.length = 7;
            Console.WriteLine(s2.length);
            Console.WriteLine(s3.length);
            Rectangle r1 = new Rectangle();
            //r1.l = -2;
            r1.setLength(2);
            r1.B = 1;
            int result1 = r1.area();
            int result2 = r1.perimeter();
            Console.WriteLine("Rectangle !!!");
            Console.WriteLine(r1.getLenght());
            Console.WriteLine(r1.B);
            Console.WriteLine("Area = " + result1);
            Console.WriteLine("perimeter = " + result2);
            Console.WriteLine("Circle !!!");
            Circle c1 = new Circle();
            c1.Radius = 2;
            
            Console.WriteLine(c1.area());
        }
    }
}
