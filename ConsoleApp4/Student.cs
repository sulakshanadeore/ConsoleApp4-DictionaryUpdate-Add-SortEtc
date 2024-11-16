using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Student
    {
        public int Studid { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }

        public List<string> ProgrammingLanguages { get; set; }


        public static List<Student> GetStudents() 
        { 
        
            List<Student> studentsList = new List<Student>();
          
            studentsList.Add(new Student
            {
                Studid = 1,
                StudentName = "Jim",
                StudentEmail = "jim@gmail.com",
                ProgrammingLanguages=new List<String> { "C", "C++", "C#" }
            });



            studentsList.Add(new Student
            {
                Studid = 2,
                StudentName = "James",
                StudentEmail = "james@gmail.com",
                ProgrammingLanguages = new List<String> { "Java", "Spring" }
            });


            studentsList.Add(new Student
            {
                Studid = 3,
                StudentName = "Kim",
                StudentEmail = "kim@gmail.com",
                ProgrammingLanguages = new List<String> { "C#", "J#", "F#","VB.NET" }
            });


            return studentsList;    

        }   
    }
}
