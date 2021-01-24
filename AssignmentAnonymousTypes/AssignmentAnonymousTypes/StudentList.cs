using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAnonymousTypes
{
    public class StudentList
    {
        private List<Student> students = new List<Student>();

        public void Add(Student student)
        {
            
            bool IsStudent = false;


            foreach (var st in students)
            {
                if (st.Id == student.Id)
                {
                    Console.WriteLine("Aynı Id de öğrenci var başka bir ıd giriniz!");
                    IsStudent = true;

                }
                else if (st.FirstName.ToLower().Equals(student.FirstName.ToLower()) && st.LastName.ToLower().Equals(student.LastName.ToLower()))
                {
                    IsStudent = true;
                }
               
            }
            if (!IsStudent)
            {
                students.Add(student);
            }
            else
            {
                Console.WriteLine("Öğrenci kaydı bulunmakta işlem iptal edildi.");
            }

        }

        public void Remove(Student student)
        {
            students.Remove(student);

        }
        public void Delete(int id)
        {
            var student = students.FirstOrDefault(st => st.Id == id);

            students.Remove(student);
        }
        public void Delete(string firstName)
        {

            var student = students.FirstOrDefault(st => st.FirstName == firstName);
            students.Remove(student);
        }

        public List<Student> GetProductsByClassroom(string classroom)
        {
            return students.Where(s => s.Classroom.Contains(classroom)).ToList();
        }

        public List<Student> GetProductsByAge(int age)
        {
            return students.Where(s => s.Age == age).ToList();
        }
        public List<Student> GetProductsById(int id)
        {
            return students.Where(s => s.Id == id).ToList();
        }

        public Student GetProductsByPhone(int phone)
        {
            return students.FirstOrDefault(p => p.Phone == phone);

        }
        public List<Student> GetAllStudent(int active)
        {
            return students.Where(s => s.Active == active).ToList();
        }
    }
}

