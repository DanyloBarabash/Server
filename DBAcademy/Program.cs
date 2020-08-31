using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace DBAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                XDocument xDoc = XDocument.Load("test.xml");
                XDocument xDoc2 = XDocument.Load("test2.xml");
                // создаем четыре объекта Authorization
                Authorization authorization1 = new Authorization { Login = "tom13", Password = "qwerty" };
                Authorization authorization2 = new Authorization { Login = "sam18", Password = "ytrewq" };
                Authorization authorization3 = new Authorization { Login = "igorvar", Password = "qwerty" };
                Authorization authorization4 = new Authorization { Login = "okneok", Password = "ytrewq" };

                // добавляем их в бд
                db.Authorizations.AddRange(new List<Authorization> { authorization1, authorization2, authorization3, authorization4 });

                //сохраняем в бд изменения
                db.SaveChanges();

                // создаем пару тестов
                Test test1 = new Test { Xml = new XCData(xDoc.ToString()) };
                Test test2 = new Test { Xml = new XCData(xDoc2.ToString()) };

                // добавляем их в бд
                db.Tests.AddRange(new List<Test> { test1, test2 });

                //сохраняем в бд изменения
                db.SaveChanges();

                // создаем два объекта Teacher
                Teacher teacher1 = new Teacher { TestId = test1.Id, AuthorizationId = authorization3.Id, FirstName = "Igor", LastName = "Varenikov" };
                Teacher teacher2 = new Teacher { TestId = test2.Id, AuthorizationId = authorization4.Id, FirstName = "Oksana", LastName = "Lepestkova" };

                // добавляем их в бд
                db.Teachers.AddRange(new List<Teacher> { teacher1, teacher2 });

                // сохраняем в бд изменения
                db.SaveChanges();
                
                // создаем два объекта груп
                Group group1 = new Group { TeacherId = teacher1.Id, Name = "SuperGroup22" };
                Group group2 = new Group { TeacherId = teacher2.Id, Name = "SuperGroup23" };

                // добавляем их в бд
                db.Groups.AddRange(new List<Group> { group1, group2 });

                // сохраняем в бд изменения
                db.SaveChanges();

                // создаем два объекта Student
                Student student1 = new Student { GroupId = group1.Id, AuthorizationId = authorization1.Id, FirstName = "Tom", LastName = "Araya" };
                Student student2 = new Student { GroupId = group1.Id, AuthorizationId = authorization2.Id, FirstName = "Sam", LastName = "Silver" };

                // добавляем их в бд
                db.Students.AddRange(new List<Student> { student1, student2 });


                // сохраняем в бд изменения
                db.SaveChanges();


                Console.WriteLine("Объекты успешно сохранены");

                
            }
            Console.Read();

        }
    }
}
