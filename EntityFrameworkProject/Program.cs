using EntityFrameworkProject.Models;
using System;
using System.Linq;

namespace EntityFrameworkProject {
    class Program {
        static void Main(string[] args) {

            var context = new AppDbContext();

            //var Students = context.Students.Where(s => s.GPA >= 3.0)
            //    .OrderBy(s => s.Lastname).ToArray();
            //var Students = context.Students.OrderBy(s => s.Firstname).ToList();

            var studentAverageSat = context.Students
                .Average(s => s.SAT);
            Console.WriteLine($"The average SAT score is {studentAverageSat}");
            //foreach(var student in Students) {
            //    Console.WriteLine($"{student.Firstname} {student.Lastname}");

            

        }
    }
}
