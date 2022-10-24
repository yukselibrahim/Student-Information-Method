using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information
{
    public class Student
    {
        private string studentNum;
        private string name;
        private string surname;
        private double exam1;
        private double exam2;
        private double examFinal;
        private string schoolName;

        public Student(string _studentNum,string _name, string _surname, double _exam1, double _exam2, double _examFinal, string _schoolName)

        {
            studentNum = _studentNum;
            name = _name;
            surname = _surname;
            exam1 = _exam1;
            exam2 = _exam2;
            examFinal = _examFinal;
            schoolName = _schoolName;
        }


        public  void StudentInfo()
        {
            Console.WriteLine("Student Number: "+studentNum);
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Surname: " + surname);
            Console.WriteLine("Student First Exam: " + exam1);
            Console.WriteLine("Student Second Exam: " + exam2);
            Console.WriteLine("Student Final Exam: " + examFinal);
            Console.WriteLine("School Name: " + schoolName);
        }


        public double ExamAverage()
        {
            double average = exam1 * 0.2 + exam2 * 0.2 + examFinal * 0.6;
            return average;
        }

        public void SchoolName()
        {
            Console.WriteLine("School Name: "+schoolName);
        }











    }
}
