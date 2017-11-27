using System;
using System.Collections.Generic;

namespace UProgram
{
    public class Degree
    {
        private string degreeName;
        private List<Course> coursesOffered;

        // getters and setters
        public string DegreeName
        {
            get
            {
                return degreeName;
            }
            set
            {
                if (value != null)
                {
                    degreeName = value;
                }
            }
        }

        public List<Course> CoursesOffered
        {
            get
            {
                return coursesOffered;
            }
        }

        // Methods
        // add a new course to coursesOffered
        public void AddCourse(Course newCourse)
        {
            coursesOffered.Add(newCourse);
        }

        // constructor
        public Degree()
        {
            this.degreeName = "";
            this.coursesOffered = new List<Course>();
        }

        public Degree(string name)
        {
            this.degreeName = name;
            this.coursesOffered = new List<Course>();
        }

        public Degree(string name, List<Course> courses)
        {
            this.degreeName = name;
            this.coursesOffered = courses;
        }
    }
}
