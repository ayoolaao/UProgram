using System;
using System.Collections.Generic;

namespace UProgram
{
    class UProgram
    {
        private string programName;
        private List<Degree> degreesOffered;

        // getters and setters
        public string ProgramName
        {
            get
            {
                return programName;
            }
            set
            {
                if (value != null)
                {
                    programName = value;
                }
            }
        }

        public List<Degree> DegreesOffered
        {
            get
            {
                return degreesOffered;
            }
        }

        // Methods
        public void AddDegree(Degree newDegree)
        {
            degreesOffered.Add(newDegree);
        }

        // Constructors
        public UProgram()
        {
            this.programName = "";
            this.degreesOffered = new List<Degree>();
        }

        public UProgram(string name)
        {
            this.programName = name;
            this.degreesOffered = new List<Degree>();
        }

        public UProgram(string name, List<Degree> degrees)
        {
            this.programName = name;
            this.degreesOffered = degrees;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            // Instantiate 3 students object
            var student1 = new Student("Ayoola Abimbola");
            var student2 = new Student("Akano Da Great");
            var student3 = new Student("Mercy Uche");
            var student4 = new Student("Shalonda Abimbola");
            var student5 = new Student("Adimu Of WolfHawkJaguar");
            var student6 = new Student("Adeola Animashaun");
            var student7 = new Student("Adrian McEvilly");
            var student8 = new Student("Segun Abimbola");
            var student9 = new Student("Ayodeji Filegbe");
            var student10 = new Student("Ajimade Animashaun");

            // Instantiate a Teacher object
            var teacher1 = new Teacher("Luther Strayer");
            var teacher2 = new Teacher("Dolores Kayata");
            var teacher3 = new Teacher("Jean Moran");
            var teacher4 = new Teacher("Rowland Isibor");

            // Instantiate Course objects - Add the students and teachers to course
            var course1 = new Course("Programming with C#", "DEV204.2x");
            course1.AddStudent(student1);
            course1.AddStudent(student2);
            course1.AddStudent(student3);

            course1.AddTeacher(teacher1);

            var course2 = new Course("Discrete Structures for CS", "CSC 400");
            course2.AddStudent(student1);
            course2.AddStudent(student2);
            course2.AddStudent(student3);
            course2.AddStudent(student7);
            course2.AddStudent(student8);
            course2.AddStudent(student9);

            course2.AddTeacher(teacher2);
            course2.AddTeacher(teacher3);

            var course3 = new Course("Data Structures I", "CSC 402");
            course3.AddStudent(student1);
            course3.AddStudent(student4);
            course3.AddStudent(student5);
            course3.AddStudent(student6);
            course3.AddStudent(student9);

            course3.AddTeacher(teacher4);

            // Instantiate a Degree object and add course to it
            var degree1 = new Degree("Bachelors");
            var degree2 = new Degree("Masters");
            var degree3 = new Degree("PHD");

            degree1.AddCourse(course1);
            degree1.AddCourse(course2);
            degree1.AddCourse(course3);

            degree2.AddCourse(course1);
            degree2.AddCourse(course3);

            degree3.AddCourse(course2);

            // Instantiate a UProgram, add Degree to Upragram
            var program1 = new UProgram("Information Technology");
            program1.AddDegree(degree1);
            program1.AddDegree(degree2);
            program1.AddDegree(degree3);

            // Write out infos
            //Console.WriteLine(program1.ProgramName);
            foreach (Degree d in program1.DegreesOffered)
            {
                Console.WriteLine($"Program: {d.DegreeName} in {program1.ProgramName}");

                Console.WriteLine("Courses offered this quarter:");
                foreach (Course c in d.CoursesOffered)
                {
                    Console.WriteLine($"\tCourse info:");
                    Console.WriteLine($"\t\tName: {c.CourseName}");
                    Console.WriteLine($"\t\tCode: {c.CourseCode}");

                    Console.WriteLine("\n\tInstructors:");
                    foreach (Teacher t in c.CourseTeachers)
                    {
                        Console.WriteLine($"\t\t{t.TeacherName}");
                    }

                    Console.WriteLine("\n\tEnrolled students:");
                    foreach (Student s in c.CourseStudents)
                    {
                        Console.WriteLine($"\t\t{s.StudentName}");
                    }
                }
                Console.WriteLine("\n");
            }

            // Print out the total number of students in the program
            Console.WriteLine($"\n\nThere are {Student.studentCount} students in this program");
        }
    }
}
