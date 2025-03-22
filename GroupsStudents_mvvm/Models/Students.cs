using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupsStudents_mvvm.Models
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; set; }
        public int Rating { get; set; }
    }
    internal class Group
    {
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
