using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class School
    {
        private string schoolName;
        private string location;
        private Student[] students;
        private int student_count;

        public School(string schoolName, string location, int MaxStudent)
        {
            this.schoolName = schoolName;
            this.location = location;
            students = new Student[MaxStudent];
            student_count = 0;
        }

        public void AddStudent(Student student)
        {
            students[student_count] = student;
            student_count++;
        }

        public string GetName()
        {
            return schoolName;
        }

        public string GetLocation()
        {
            return location;
        }

        public Student[] GetStudents()
        {
            return students;
        }
    }
}