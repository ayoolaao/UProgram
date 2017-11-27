using System;
namespace UProgram
{
    public class Teacher
    {
        private string teacherName;

        public string TeacherName
        {
            get
            {
                return teacherName;
            }
            set
            {
                if (value != null)
                {
                    teacherName = value;
                }
            }
        }

        // constructor
        public Teacher()
        {

        }

        public Teacher(string name)
        {
            this.teacherName = name;
        }
    }
}
