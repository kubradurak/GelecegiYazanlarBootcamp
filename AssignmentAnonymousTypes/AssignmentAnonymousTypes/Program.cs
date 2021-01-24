using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new StudentList();
            list.Add(new Student { Id=1, FirstName="kübra", LastName="durak", Email="kubra@mail.com" ,Phone= 0000000, Age=7, Classroom="1A", Active=1 });
            list.Add(new Student { Id=2, FirstName="beyza", LastName="özütemiz", Email="beyza@mail.com" ,Phone= 1111111, Age=7, Classroom="1A", Active =1  });
            list.Add(new Student { Id=3, FirstName="ömriye", LastName="çelik", Email="omriye@mail.com" ,Phone= 2222222, Age=7, Classroom="1A", Active=1 });
            list.Add(new Student { Id=4, FirstName="irem", LastName="şahin", Email="irem@mail.com" ,Phone= 3333333, Age=8, Classroom="2B" , Active= 1});
            list.Add(new Student { Id=5, FirstName="naime", LastName="erden", Email="naime@mail.com" ,Phone= 4444444, Age=8, Classroom="2B" , Active=1});

            Console.WriteLine("1-A sınıf öğrencilerin listesi ");
            var AClassrom = list.GetProductsByClassroom("1A");
            AClassrom.ForEach(student => Console.WriteLine($"{student.FirstName} isimli öğrenci {student.Classroom} sınıfına ait. "));

            Console.WriteLine("---------------------------------------------------------------------------");

            Console.WriteLine("2B sınıf öğrencilerin listesi ");
            var BClassroom = list.GetProductsByClassroom("2B");
            AClassrom.ForEach(student => Console.WriteLine($"{student.FirstName} isimli öğrenci {student.Classroom} sınıfına ait. "));

            Console.WriteLine("--------------------------------------------------------------------------");

            list.Add(new Student { Id = 6, FirstName = "ruken", LastName = "sancar", Email = "ruken@mail.com", Phone = 55555555, Age = 7, Classroom = "1B", Active =1 });

            Console.WriteLine("--------------------------------------------------------------------------");


            Console.WriteLine("Aynı yaştaki öğrencilerin listesi: ");
            var sevenAge = list.GetProductsByAge(7);
            sevenAge.ForEach(s => Console.WriteLine($"{s.FirstName} isimli öğrenci {s.Age} yaşında ve {s.Classroom} sınıfındadır."));

            Console.WriteLine("-------------------------------------------------------------------------");

            //var findingbyPhone = list.GetProductsByPhone(2222222);
            //Console.WriteLine($"{findingbyPhone.Phone} nolu telefon  {findingbyPhone.FirstName} {findingbyPhone.LastName} kişisine aittir.");

            Console.WriteLine("---------3 numaralı öğrenci silindi-------------------------------------");
            list.Delete(3);

            Console.WriteLine("--------Tüm öğrenciler--------------------------");
            var allList = list.GetAllStudent(1);
            allList.ForEach(student => Console.WriteLine($"{student.FirstName}, {student.LastName}"));

            list.Add(new Student { Id = 8, FirstName = "rumeysa", LastName = "tan", Email = "ruken@mail.com", Phone = 55555555, Age = 7, Classroom = "1B" , Active=1 });
            //list.Add(new Student { Id = 7, FirstName = "ruken", LastName = "sancar", Email = "ruken@mail.com", Phone = 55555555, Age = 7, Classroom = "1B", Active = 1 });
            Console.WriteLine("--------Tüm öğrenciler--------------------------");
            var allList2 = list.GetAllStudent(1);
            allList2.ForEach(student => Console.WriteLine($"{student.FirstName}, {student.LastName}"));
            try
            {
                Console.WriteLine("Eklemek istediğiniz öğrencinin adını giriniz:");
                string addedStudentFirstName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Eklemek istediğiniz öğrenciye ait bir Id giriniz:");
                int addedStudentId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Eklemek istediğiniz öğrencinin soyadını giriniz:");
                string addedStudentLastName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Eklemek istediğiniz öğrencinin mailini giriniz:");
                string addedStudentMail = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Eklemek istediğiniz öğrencinin telefonunu giriniz:");
                int addedStudentPhone = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Eklemek istediğiniz öğrencinin yaşını giriniz:");
                int addedStudentAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Eklemek istediğiniz öğrencinin sınıfını giriniz:(1A-1B-2B)");
                string addedStudentClassroom = Convert.ToString(Console.ReadLine());
                int addedStudentActive = 1;

                list.Add(new Student { Id = addedStudentId, FirstName = addedStudentFirstName, LastName = addedStudentLastName, Email = addedStudentMail, Phone = addedStudentPhone, Age = addedStudentAge, Classroom = addedStudentClassroom, Active = addedStudentActive });

            }
            catch (FormatException exception)
            {
                Console.WriteLine("Lütfen Formatları doğru giriniz!");
            }
            
            Console.WriteLine("----------- Yeni öğrenci listesi --------------------");
            var allList_new = list.GetAllStudent(1);
            allList_new.ForEach(student => Console.WriteLine($"{student.FirstName} {student.LastName} {student.Classroom} nın öğrencisidir."));

            

            

            
            Console.WriteLine("Aramak istediğiniz öğrencinin sınıfını giriniz:(1A- 1B- 2B ) ");
            string findClassroom = Convert.ToString(Console.ReadLine());
            var findClassroomList = list.GetProductsByClassroom(findClassroom);
            findClassroomList.ForEach(s => Console.WriteLine($"{s.FirstName} isimli öğrenci {s.Classroom} sınıfındadır."));
            Console.WriteLine("Silmek istediğiniz öğrencinin adını giriniz: ");
            Console.WriteLine("Listeden çıkarmak istediğiniz öğrencinin adını giriniz: ");
            string deletedStudentfirstName = Convert.ToString(Console.ReadLine());
            list.Delete(deletedStudentfirstName);

            var allList_new2 = list.GetAllStudent(1);
            allList_new2.ForEach(student => Console.WriteLine($"{student.FirstName} {student.LastName} {student.Classroom} nın öğrencisidir."));


            Console.ReadLine();




        }

    }
}
