using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("1","İbrahim","Yüksel",50,55,73,"Jozef Pilsudski University");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("********************Welcome********************");
            Console.WriteLine();

            bool control = true;
            Console.ForegroundColor = ConsoleColor.White;
            while (control)
            {
                Console.WriteLine();
                Options();
                string select = Console.ReadLine();
                Console.WriteLine();

                switch (select)
                {
                    case "1":
                      student1.StudentInfo();
                        break;

                    case "2":
                        double examAverage = student1.ExamAverage();
                        Console.WriteLine("Student's Exam Average: "+examAverage);
                        break;

                    case "3":
                        student1.SchoolName();
                        break;

                    case "4":
                        control = false;
                        break;
                        
                }
            }

            Console.WriteLine("Have a nice day");
            Console.ReadLine();

        }

        static void Options()
        {
            Console.WriteLine("1- Student's Informations");
            Console.WriteLine("2- Student's Exam Average");
            Console.WriteLine("3- Student's School Name");
            Console.WriteLine("4- Exit");
        }
    }
}
