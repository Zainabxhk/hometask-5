using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding Students");
            Student std1 = new Student(1, "Ali");
            Student std2 = new Student(2, "Alee");
            Student std3 = new Student(3, "Umar");
            Console.WriteLine("Adding Teacher");
            Teacher teacher1 = new Teacher(1, "Muhammad", "OOP");
            Teacher teacher2 = new Teacher(2, "Yasir", "DLD");
            Console.WriteLine("School");
            School school = new School("NTU", "FSD", 20);

            Console.WriteLine("Adding Student to School");
            school.AddStudent(std1);
            school.AddStudent(std2);
            school.AddStudent(std3);

            Console.WriteLine("Assigning Grade to student");
            teacher1.AssignGrade(std1, 90);
            teacher2.AssignGrade(std1, 80);
            teacher1.AssignGrade(std2, 70);
            teacher2.AssignGrade(std2, 75);
            teacher2.AssignGrade(std3, 60);
            teacher1.AssignGrade(std3, 50);

            Console.WriteLine("Display Average of Grade of each student");
            Console.WriteLine(std1.GetName() + " Has Average " + std1.CalculateAverageGrade());
            Console.WriteLine(std2.GetName() + " Has Average " + std2.CalculateAverageGrade());
            Console.WriteLine(std3.GetName() + " Has Average " + std3.CalculateAverageGrade());

            Console.WriteLine("Information of School");
            Console.WriteLine(school.GetName());
            Console.WriteLine(school.GetLocation());

            foreach (Student std in school.GetStudents())
            {
                if (std != null)
                {
                    Console.WriteLine(std.GetName());
                    Console.WriteLine(std.GetStudent_ID());
                }
            }
        }
    }
}