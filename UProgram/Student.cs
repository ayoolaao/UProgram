using System;
using System.Collections.Generic;

namespace UProgram
{
    public class Student
    {
        private string studentName;
        public static int studentCount = 0;

        public string StudentName
        {
            get
            {
                return studentName;
            }
            set
            {
                if (value != null)
                {
                    studentName = value;
                }
            }
        }

        // constructor
        public Student()
        {
            this.studentName = "";
            studentCount++;
        }

        public Student(string name)
        {
            this.studentName = name;
            studentCount++;
        }
    }
}
