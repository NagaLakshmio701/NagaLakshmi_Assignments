using System;
using System.Collections.Generic;

namespace HandsOnGenericCollections
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }

        public override string ToString()
        {
            return $"ID: {StudentId}, Name: {Name}, Age: {Age}, Grade: {Grade}";
        }
    }

    interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int studentId);
        void AddStudent(Student student);
        void RemoveStudent(int studentId);
        void UpdateStudent(Student student);
    }

    class StudentRepository : IStudentRepository
    {
        List<Student> students = new List<Student>(); // Data source

        public void AddStudent(Student student)
        {
            // Add student to the list
            students.Add(student);
        }

        public List<Student> GetAllStudents()
        {
            // Return all students
            return students;
        }

        public Student GetStudentById(int studentId)
        {
            foreach (Student student in students)
            {
                if (student.StudentId == studentId) return student;
            }
            return null; // When given student ID does not exist
        }

        public void RemoveStudent(int studentId)
        {
            Student studentToRemove = null;
            foreach (Student student in students)
            {
                if (student.StudentId == studentId)
                {
                    studentToRemove = student;
                    break;
                }
            }
            if (studentToRemove != null)
                students.Remove(studentToRemove);
        }

        public void UpdateStudent(Student updatedStudent)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].StudentId == updatedStudent.StudentId)
                {
                    students[i] = updatedStudent; // Update student details
                }
            }
        }
    }

    internal class Demo
    {
        static void Main()
        {
            StudentRepository repository = new StudentRepository();
            do
            {
                Console.WriteLine("1. Add\n2. GetById\n3. GetAll\n4. Update\n5. Delete\n6. Exit");
                Console.WriteLine("Select Option:");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: // Add Student
                        {
                            Student student = new Student();
                            student.StudentId = new Random().Next();
                            Console.WriteLine("Enter Name:");
                            student.Name = Console.ReadLine();
                            Console.WriteLine("Enter Age:");
                            student.Age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Grade:");
                            student.Grade = Console.ReadLine();
                            repository.AddStudent(student);
                        }
                        break;
                    case 2: // Search Student
                        {
                            Console.WriteLine("Enter Student Id:");
                            int id = int.Parse(Console.ReadLine());
                            Student student = repository.GetStudentById(id);
                            if (student != null)
                            {
                                Console.WriteLine(student.ToString());
                            }
                            else
                                Console.WriteLine("Invalid Id");
                        }
                        break;
                    case 3: // Get All Students
                        {
                            List<Student> students = repository.GetAllStudents();
                            if (students.Count > 0)
                            {
                                foreach (var item in students)
                                {
                                    Console.WriteLine(item);
                                }
                            }
                            else
                                Console.WriteLine("List is Empty");
                        }
                        break;
                    case 5: // Delete Student
                        {
                            Console.WriteLine("Enter Student Id:");
                            int id = int.Parse(Console.ReadLine());
                            repository.RemoveStudent(id);
                        }
                        break;
                    case 4: // Update Student
                        {
                            Student student = new Student();
                            Console.WriteLine("Enter Student Id:");
                            student.StudentId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Name:");
                            student.Name = Console.ReadLine();
                            Console.WriteLine("Enter Age:");
                            student.Age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Grade:");
                            student.Grade = Console.ReadLine();
                            repository.UpdateStudent(student);
                        }
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            } while (true);
        }
    }
}
