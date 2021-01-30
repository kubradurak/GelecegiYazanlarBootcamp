using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormNetCore.Models
{
    public static class EnrolledStudents
    {
        public static List<Student> enrolledStudents = new List<Student>();

        public static void Add(Student student)
        {
            enrolledStudents.Add(student);
        }
        public static void GetStudentList()
        {
            enrolledStudents.ToList();
            // kapsülleme için
        }
    }
}
