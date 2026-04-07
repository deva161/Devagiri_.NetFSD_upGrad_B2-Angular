using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentMarks { get; set; }

    }

    class StudentManageData
    {
        List<Student> Students = new List<Student>();

        public List<Student> GetStudents(Student student)
        {
            Students.Add(student);
            return Students;
        }

    }

    class GenerateReports
    {
        public void Reports(List<Student> Students)
        {
            foreach (var student in Students)
            {
                Console.WriteLine($"Student Id : {student.StudentId}\tStudent Name : {student.StudentName}\tStudent Marks : {student.StudentMarks}");
            }
        }
    }
    internal class problem1
    {
        static void Main()
        {
            Student student1 = new Student();

            student1.StudentId = 10;
            student1.StudentName = "Vasu";
            student1.StudentMarks = 75;


            StudentManageData manageData = new StudentManageData();

            var DataList=manageData.GetStudents(student1);

            GenerateReports reports = new GenerateReports();

            reports.Reports(DataList);
        }
    }
}
