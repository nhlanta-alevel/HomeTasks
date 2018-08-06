using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Group
    {
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        private Student[] _students;
        public Group(string name, Teacher teacher, Student[] students)
        {
            if (teacher == null)
                throw new ArgumentNullException("teacher");

            Name = name;
            Teacher = teacher;
            Students = students;
        }
        public Student[] Students
        {
            get { return _students; }
            set
            {
                if (Teacher.TeacherType == TeacherType.Docent && value.Length >20)
                {
                    throw new Exception("Docent shouldn't have more than 20 students");
                }
                if (Teacher.TeacherType == TeacherType.Lector && value.Length > 15)
                {
                    throw new Exception("Lector shouldn't have more than 15 students");
                }
                if (Teacher.TeacherType == TeacherType.Assistent && value.Length > 5)
                {
                    throw new Exception("Assistent shouldn't have more than 5 students");
                }
                _students = value;
            }
        }

    }
}
