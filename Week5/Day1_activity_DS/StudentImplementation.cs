using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Day2
{
    internal class ArraylistDemoImplementation
    {
        static void Main()
        {

            List<int> list = new List<int>();

            Dictionary<string, int> dict = new Dictionary<string, int>();
            Console.Write("Enter number of Students : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter Student{i + 1} : ");
                string name = Console.ReadLine();
                Console.Write($"Enter marks{i + 1} : ");
                int marks = Convert.ToInt32(Console.ReadLine());
                Student s = new Student(name, marks);
                dict[s.name] = s.marks;
            }

            foreach (var item in dict.Keys)
            {
                list.Add(dict[item]);
            }
            int sum = 0;

            foreach (var item in list)
            {
                sum += item;
            }
            double avg = list.Average();
            int max = list.Max();
            int count = 0;
            foreach (var item in list)
            {
                if (item > 80)
                {
                    count += 1;
                }
            }
            Console.WriteLine($"Total Sum of marks {sum}");
            Console.WriteLine($"Average Marks {avg}");
            Console.WriteLine($"Students above 80 is {count}");
            Console.WriteLine($"Maximum Marks is {max}");
        }
    }
}