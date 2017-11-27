using System;
using System.Collections.Generic;

namespace UProgram
{
    public class Course
    {
        private string courseName;
        private string courseCode;
        private List<Student> courseStudents;
        private List<Teacher> courseTeachers;

        // getters and setters
        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                if (value != null)
                {
                    courseName = value;
                }
            }
        }

        public string CourseCode
        {
            get
            {
                return courseCode;
            }
            set
            {
                if (value != null)
                {
                    courseCode = value;
                }
            }
        }

        public List<Student> CourseStudents
        {
            get
            {
                return courseStudents;
            }
        }

        public List<Teacher> CourseTeachers
        {
            get
            {
                return courseTeachers;
            }
        }

        // Methods
        // add a new student to courseStudents
        public void AddStudent(Student newStudent)
        {
            courseStudents.Add(newStudent);
        }

        // add a new Teacher to courseTeachers
        public void AddTeacher(Teacher newTeacher)
        {
            courseTeachers.Add(newTeacher);
        }

        // constructors
        public Course()
        {
            this.courseName = "";
            this.courseCode = "";
            this.courseStudents = new List<Student>();
            this.courseTeachers = new List<Teacher>();
        }

        public Course(string name)
        {
            this.courseName = name;
            this.courseStudents = new List<Student>();
            this.courseTeachers = new List<Teacher>();
        }

        public Course(string name, string code)
        {
            this.courseName = name;
            this.courseCode = code;
            this.courseStudents = new List<Student>();
            this.courseTeachers = new List<Teacher>();
        }
    }
}
