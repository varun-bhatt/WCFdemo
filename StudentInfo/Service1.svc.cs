using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Serialization;

namespace StudentInfo
{
    
        public class Service1 : IStudent
        {
        List<Student1> all_students = new List<Student1>();
        Filters fs = new Filters();
        public List<Student1> GetStudent()
            {
                Student1 objStudent = new Student1();
                objStudent.StudentId = 1;
                objStudent.StudentName = "Varun";
                objStudent.Number = "9726399744";
                objStudent.StudentCity = "Ahmedabad";
                objStudent.StudentSurname = "Bhatt";


                Student1 objStudent2 = new Student1();
                objStudent2.StudentId = 2;
                objStudent2.StudentName = "Namrata";
                objStudent2.Number = "9854799585";
            objStudent2.StudentCity = "Vadodara";
            objStudent2.StudentSurname = "Ajmeri";

            Student1 objStudent3 = new Student1();
                objStudent3.StudentId = 3;
                objStudent3.StudentName = "Pramod";
                objStudent3.Number = "9876543210";
                objStudent3.StudentCity = "Nadiad";
                objStudent3.StudentSurname = "Patel";

            all_students.Add(objStudent);
                all_students.Add(objStudent2);
                all_students.Add(objStudent3);
            return all_students;
            }
        List<Student1> specific_student = new List<Student1>();
        public List<Student1> GetStudentById(string id1)
        {
            int id = Convert.ToInt32(id1);
            all_students = GetStudent();
          
            foreach (Student1 element in all_students)
            {
               
                if (element.StudentId == id)
                {
                    Student1 s = new Student1();
                    s.StudentId = element.StudentId;
                    s.StudentName = element.StudentName;
                    s.Number = element.Number;
                    specific_student.Add(s);
                    return specific_student;
                }
            }


     

            return specific_student;
        }
        List<Student1> specific_student1 = new List<Student1>();
        public List<Student1> GetStudentByObject(Filters fs)
        {
           /* DataContractJsonSerializer ser =
                  new DataContractJsonSerializer(typeof(Filters));*/
            
            string s1 = fs.StudentCity;
            string s2 = fs.StudentSurname;
            all_students = GetStudent();
            
            foreach (Student1 element in all_students)
            {
                if ((element.StudentCity.Equals(s1)) && (element.StudentSurname.Equals(s2)))
                {
                    Student1 stu = new Student1();
                    stu.StudentId = element.StudentId;
                    stu.StudentName = element.StudentName;
                    stu.Number = element.Number;
                    stu.StudentCity = element.StudentCity;
                    stu.StudentSurname = element.StudentSurname;
                    specific_student1.Add(stu);
                    return specific_student1;
                }
            }
            return specific_student1;

        }
    }
}

