using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Student
    {
        private int student_ID;
        private string name;
        private int[] grade;
        private int grade_count;

        public Student(int studentId, string studentName)
        {
            this.student_ID = studentId;
            name = studentName;
            grade = new int[5];
            grade_count = 0;
        }
        public void SetGrade(int Grade)
        {
            grade[grade_count] = Grade;
            grade_count++;
        }
        public double CalculateAverageGrade()
        {
            if (grade_count == 0)
            {
                return 0;
            }
            double sum = 0;
            for (int i = 0; i < grade_count; i++)
            {
                sum += grade[i];
            }
            return sum / grade_count;
        }

        public int GetStudent_ID()
        {
            return student_ID;
        }
        public string GetName()
        {
            return name;
        }
    }
}