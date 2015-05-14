using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleEight
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Albert", "Einstein");
            student1.Grades(90);
            student1.Grades(80);
            student1.Grades(70);
            student1.Grades(60);
            student1.Grades(50);
            Student student2 = new Student("Albert", "Einstein");
            student2.Grades(90);
            student2.Grades(80);
            student2.Grades(70);
            student2.Grades(60);
            student2.Grades(50);
            Student student3 = new Student("Albert", "Einstein");
            student3.Grades(90);
            student3.Grades(80);
            student3.Grades(70);
            student3.Grades(60);
            student3.Grades(50);
            Course course = new Course("Programming with C#");
            course.Students(student1);
            course.Students(student2);
            course.Students(student3);
            Teacher teacher = new Teacher();
            course.Teachers(teacher);
            Degree degree = new Degree("Bachelor");
            degree.Courses(course);
            UProgram uProgram = new UProgram("Information Technology");
            uProgram.Degrees(degree);
            List<Degree> degrees = uProgram.Degrees();
            Console.WriteLine("The " + uProgram.Name + " program contains the " + degrees[0].Name + " of Science degree");
            Console.WriteLine();
            List<Course> courses = degrees[0].Courses();
            Console.WriteLine("The " + degrees[0].Name + " of Science degree contains the course " + courses[0].Name);
            List<Student> students = courses[0].Students();
            courses[0].ListStudents();
            Console.WriteLine();
            Console.WriteLine("The " + courses[0].Name + " course contains " + students.Count + " students(s)");
        }
    }
    abstract class Person
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }
    class Student : Person
    {
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            _grades = new Stack<int>();
        }
        private Stack<int> _grades;
        public void Grades(int score)
        {
            _grades.Push(score);
        }
        public void TakeTest()
        {

        }
    }
    class Teacher : Person
    {
        public void GradeTest()
        {

        }
    }
    class UProgram
    {
        private string _name;
        public UProgram(String name)
        {
            this.Name = name;
            this._degrees = new List<Degree>();
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private List<Degree> _degrees;
        public void Degrees(Degree degree)
        {
            _degrees.Add(degree);
        }
        public List<Degree> Degrees()
        {
            return _degrees;
        }
    }
    class Degree
    {
        private string _name;
        public Degree(string name)
        {
            this.Name = name;
            this._courses = new List<Course>();
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private List<Course> _courses;
        public void Courses(Course course)
        {
            _courses.Add(course);
        }
        public List<Course> Courses()
        {
            return _courses;
        }
    }
    class Course
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Course(string name)
        {
            this.Name = name;
            this._students = new List<Student>();
            this._teachers = new List<Teacher>();
        }
        private List<Student> _students;
        public void Students(Student student)
        {
            _students.Add(student);
        }
        public void ListStudents()
        {
            foreach (Student student in _students)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
        public List<Student> Students()
        {
            return _students;
        }
        private List<Teacher> _teachers;
        public void Teachers(Teacher teacher)
        {
            _teachers.Add(teacher);
        }
        public List<Teacher> Teachers()
        {
            return _teachers;
        }

    }
}
