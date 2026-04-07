using System;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;


public record Student(int id, string name, string course, byte marks);

namespace StudentRecords
{
    internal class StudentRecoredsImplementation
    {
        public static List<Student> InputData(int num)
        {
            List<Student> list = new List<Student>();
            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter Students id : ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Students name : ");
                string name = Console.ReadLine();

                Console.Write("Enter Students course : ");
                string course = Console.ReadLine();

                Console.Write("Enter Students marks : ");
                byte marks = Convert.ToByte(Console.ReadLine());

                list.Add(new Student(id, name, course, marks));

            }
            return list;
        }
        static void DisplayData(List<Student> data)
        {
            foreach (var std in data)
            {
                Console.WriteLine($"Student id : {std.id} | Student name : {std.name} | Student course : {std.course} | Student marks : {std.marks}");
            }
        }
        static string SearchData(List<Student> data,int target)
        {
            foreach (var std in data)
            {
                if(std.id == target)
                {
                   return $"Student id : {std.id} | Student name : {std.name} | Student course : {std.course} | Student marks : {std.marks}";
                }
            }
            return "details not found";
        }
        static void Main()
        {
            Console.Write("Enter number of Students Data : ");
            int num = Convert.ToInt32(Console.ReadLine());

            List<Student> data = InputData(num);

            Console.WriteLine("Student records : ");
            DisplayData(data);
            Console.WriteLine();

            Console.Write("Enter Students id to Search : ");
            int id = Convert.ToInt32(Console.ReadLine());

            string element = SearchData(data, id);
            Console.WriteLine("Student Details Found.");
            Console.WriteLine(element);
        }
    }
}
