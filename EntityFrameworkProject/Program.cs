using EntityFrameworkProject.Models;
using System;
using System.Linq;

namespace EntityFrameworkProject {
    class Program {
        static void Main(string[] args) {

            var context = new AppDbContext();

            //To Update
            var student = context.Students.Find(6);
            if(student == null) {
                throw new Exception("Not found!");
            }
            student.MajorId = 16;
            

            context.SaveChanges();

            //var major = context.Majors.SingleOrDefault(m => m.Description == "eSports"); //Displays the major where description Comp Sci; else null

            //var student = new Student {
            //    Firstname = "James",
            //    Lastname = "Brown",
            //    GPA = 2.8,
            //    SAT = 1100,
            //    IsFulltime = false,
            //    MajorId = major.Id
            //};
            //    context.Students.Add(student);


            //major = context.Majors.SingleOrDefault(m => m.Description == "Theater");
            //student = new Student {
            //    Firstname = "Jimmy",
            //    Lastname = "Neutron",
            //    GPA = 5.0,
            //    SAT = 2500,
            //    IsFulltime = true,
            //    MajorId = major.Id
            //};
            //    context.Students.Add(student);


            //major = context.Majors.SingleOrDefault(m => m.Description == "Golf Science");
            //student = new Student {
            //    Firstname = "Timmy",
            //    Lastname = "Turner",
            //    GPA = 2.5,
            //    SAT = 1300,
            //    IsFulltime = true,
            //    MajorId = major.Id
            //};
            //    context.Students.Add(student);


            // major = context.Majors.SingleOrDefault(m => m.Description == "Sociology");
            //student = new Student {
            //    Firstname = "Susie",
            //    Lastname = "Rogers",
            //    GPA = 4.6,
            //    SAT = 1000,
            //    IsFulltime = false,
            //    MajorId = major.Id
            //};
            //    context.Students.Add(student);


            //context.SaveChanges();

            //var major = new Major();
            //major.Id = 0;
            //major.Description = "Nursing";
            //major.MinSAT = 1100;
            //context.Majors.Add(major); // Could also use AddRange using all variable names

            //var major1 = new Major();
            //major1.Id = 0;
            //major1.Description = "Accounting";
            //major1.MinSAT = 1300;
            //context.Majors.Add(major1);

            //var major2 = new Major();
            //major2.Id = 0;
            //major2.Description = "Public Speaking";
            //major2.MinSAT = 5;
            //context.Majors.Add(major2);

            //var major3 = new Major();
            //major3.Id = 0;
            //major3.Description = "Golf Science";
            //major3.MinSAT = 1400;
            //context.Majors.Add(major3);

            //var major4 = new Major();
            //major4.Id = 0;
            //major4.Description = "eSports";
            //major4.MinSAT = 800;
            //context.Majors.Add(major4);

            //var major5 = new Major();
            //major5.Id = 0;
            //major5.Description = "Sociology";
            //major5.MinSAT = 800;
            //context.Majors.Add(major5);

            //var major6 = new Major();
            //major6.Id = 0;
            //major6.Description = "History";
            //major6.MinSAT = 900;
            //context.Majors.Add(major6);

            //var major7 = new Major();
            //major7.Id = 0;
            //major7.Description = "Political Science";
            //major7.MinSAT = 1000;
            //context.Majors.Add(major7);

            //var major8 = new Major();
            //major8.Id = 0;
            //major8.Description = "Theater";
            //major8.MinSAT = 200;
            //context.Majors.Add(major8);

            //var major9 = new Major();
            //major9.Id = 0;
            //major9.Description = "Computer Science";
            //major9.MinSAT = 1500;
            //context.Majors.Add(major9);

            //var major = context.Majors.Find(2);
            //if(major == null) {
            //    throw new Exception("Not found!");
            //}
            //major.Description = "Math";
            //major.MinSAT = 1300;

            //var major = new Major();
            //major.Id = 0;
            //major.Description = "Biology";
            //major.MinSAT = 1100;

            //context.Majors.Add(major);
            //context.SaveChanges();


            //foreach(var major in context.Majors.ToList()) {
            //    Console.WriteLine(major);
            //}

            //var genStudies = context.Majors.Find(1);
            //Console.WriteLine(genStudies);

            //var Students = context.Students.Where(s => s.GPA >= 3.0)
            //    .OrderBy(s => s.Lastname).ToArray();
            //var Students = context.Students.OrderBy(s => s.Firstname).ToList();

            //var studentAverageSat = context.Students
            //    .Average(s => s.SAT);
            //Console.WriteLine($"The average SAT score is {studentAverageSat}");

            //var students = context.Students.ToArray();
            //foreach (var student in students) {
            //    var major = (student.Major == null) ? "Undeclared" : student.Major.Description; //Ternary Operator basic If, Then, Else statement
            //    //If student doesnt hve a major "Null" then display Undeclared. Else display the Major. 
            //    Console.WriteLine (student);

            //List students in ascending order by major description
            //var students = context.Students.Where(s => s.Major != null)
            //                .OrderBy(student => student.Major.Description)
            //                .ToList();

            //foreach (var student in students) {

            //    Console.WriteLine(student);
            //}
        }
    }
}
