using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    using System.Collections.Generic;

    public interface IStudentRepository
    {
        void AddStudent(Student student);
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        void DeleteStudent(int id);
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Course { get; set; }
    }
public class StudentRepository : IStudentRepository
    {
        // Data Storage (In-memory)
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetStudentById(int id)
        {
            return students.FirstOrDefault(s => s.StudentId == id);
        }

        public void DeleteStudent(int id)
        {
            var student = GetStudentById(id);
            if (student != null)
            {
                students.Remove(student);
            }
        }
    }
 
public class StudentService
    {
        private readonly IStudentRepository repository;

        public StudentService(IStudentRepository repo)
        {
            repository = repo;
        }

        public void AddStudent(Student student)
        {
            repository.AddStudent(student);
        }

        public void ShowAllStudents()
        {
            List<Student> students = repository.GetAllStudents();

            foreach (var s in students)
            {
                Console.WriteLine($"ID: {s.StudentId}, Name: {s.StudentName}, Course: {s.Course}");
            }
        }

        public void FindStudent(int id)
        {
            var student = repository.GetStudentById(id);

            if (student != null)
            {
                Console.WriteLine($"Found → ID: {student.StudentId}, Name: {student.StudentName}, Course: {student.Course}");
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }

        public void DeleteStudent(int id)
        {
            repository.DeleteStudent(id);
            Console.WriteLine("Student deleted (if existed)");
        }
    }
    internal class problem7
    {
        static void Main(string[] args)
        {
            IStudentRepository repo = new StudentRepository();
            StudentService service = new StudentService(repo);

            // Adding Students
            service.AddStudent(new Student { StudentId = 1, StudentName = "Vasu", Course = "Java" });
            service.AddStudent(new Student { StudentId = 2, StudentName = "Ravi", Course = "Python" });
            service.AddStudent(new Student { StudentId = 3, StudentName = "Anil", Course = ".NET" });

            Console.WriteLine("All Students:");
            service.ShowAllStudents();

            Console.WriteLine("\nFind Student with ID 2:");
            service.FindStudent(2);

            Console.WriteLine("\nDelete Student with ID 1:");
            service.DeleteStudent(1);

            Console.WriteLine("\nAll Students After Deletion:");
            service.ShowAllStudents();
    }
}
}
