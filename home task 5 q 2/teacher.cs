using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Teacher
    {
        private int Teacher_ID;
        private string Teacher_Name;
        private string Subject;

        public Teacher(int ID, string Name, string Sub)
        {
            Teacher_ID = ID;
            Teacher_Name = Name;
            Subject = Sub;
        }
        public void AssignGrade(Student std, int Grade)
        {
            std.SetGrade(Grade);
        }
        public int GetTeacher_ID() { return Teacher_ID; }
        public string GetTeacher_Name() { return Teacher_Name; }
        public string GetSubject() { return Subject; }

    }
}