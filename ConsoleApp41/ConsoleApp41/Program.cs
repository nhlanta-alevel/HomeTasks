using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student { FirstName = "Vasya", LastName = "Pupk" };
            Student s2 = new Student { FirstName = "Nadya", LastName = "Petrova" };
            Student s3 = new Student { FirstName = "Oleg", LastName = "Ivanov" };
            Student s4 = new Student { FirstName = "Olya", LastName = "Sidorova" };

            Teacher teacher1 = new Teacher("Nikolay", "Voroncov", TeacherType.Assistent);
            Teacher teacher2 = new Teacher("Petr", "Zhukov", TeacherType.Docent);
            Teacher teacher3 = new Teacher("Vadim", "Lahnov", TeacherType.Lector);

            Group group1 = new Group ("ASU1", teacher1, new Student[] { s1, s2 });
            Group group2 = new Group ("ASU2", teacher2, new Student[] { s3, s4 });

            Teacher[] teachers = new Teacher[] { teacher1, teacher2, teacher3 };

            Subject subject1 = new Subject { Name = "Math", Hours = 120 };
            Subject subject2 = new Subject { Name = "English", Hours = 180 };
            Subject[] subjects = new Subject[] { subject1, subject2 };

            University university = new University
            {
                Groups = new Group[] { group1, group2 },
                Students = new Student[] { s1, s2, s3, s4 },
                Subjects = subjects,
                Teachers = teachers
            };


            //List<Student> listOfStudents = new List<Student>();
            //List<Group> listOfGroups = new List<Group>();

            //string firstName = Console.ReadLine();
            //string lastName = Console.ReadLine();
            //Student st = new Student { FirstName = "Vasya", LastName = "Pupk" };
            //listOfStudents.Add(st);

            //listOfStudents.Add(s2);
            //listOfStudents.Add(s3);
            //listOfStudents.Add(s4);


        }
    }
}
