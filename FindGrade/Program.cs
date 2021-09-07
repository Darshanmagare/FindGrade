using System;

namespace FindGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Student obj = new Student();
            obj.findGrade();

        }
}

    public class Student
    { 
        public void findGrade()
        {

            int num1, num2, num3,num4,num5, avg = 0;
            string grade;

            Console.WriteLine("---Student Marks Calculation Program in C#---\n");
            Console.Write("Enter Marks Of subject 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks Of subject 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks Of subject 3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks Of subject 4: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks Of subject 5: ");
            num5 = Convert.ToInt32(Console.ReadLine());


            if (num1 > 100 || num2 > 100 || num3 > 100 || num4 > 100 || num5 > 100) grade = "Error";
            else if (num1 < 0 || num2 < 0 || num3 < 0 || num4 < 0 || num5 < 0) grade = "Error";
            else
            {
                avg = (num1 + num2 + num3 + num4 + num5) / 5;

                if (avg > 100) grade = "Error";
                else if (avg < 0) grade = "Error";
                else if (avg > 90) grade = "A+";
                else if (avg > 70) grade = "B+";
                else if (avg > 50) grade = "C+";
                else if (avg > 30) grade = "C";
                else grade = "F";

            }
            System.Console.Write("{0}\t{1}\t\n", avg, grade);
            Console.ReadLine();
        }

    
    }
}
