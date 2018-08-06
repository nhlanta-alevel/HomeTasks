using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    enum TeacherType
    {
        Docent,
        Lector,
        Assistent
    }
    class Teacher: Person
    {
        public TeacherType TeacherType { get; set; }
        public Teacher(string firstName, string lastName, TeacherType teacherType)
        {
            FirstName = firstName;
            LastName = lastName;
            TeacherType = teacherType;
        }
    }
}
