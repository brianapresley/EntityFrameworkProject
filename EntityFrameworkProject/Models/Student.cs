using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFrameworkProject.Models {

    public class Student {

        public int Id { get; set; }
        [Required] //Annotation must come right before the thing they modify [Required] = not null 
        [StringLength(30)] //[StringLength(30)] = maximum length 30 characters
        public string Firstname { get; set; }
        [Required]
        [StringLength(30)]
        public string Lastname { get; set; }
        [Range(600, 2400, ErrorMessage = "SAT score 600 <= x <= 2400")]
        public int SAT { get; set; }
        public double GPA { get; set; }
        public bool IsFulltime { get; set; } = true;

        public int? MajorId { get; set; } //foreign key to Majors table, int? allows the int to be null
        public virtual Major Major { get; set; } //tells EF that this data does not exist in the student table but appears as a property of student, does not show in student table
        //Tells EF if student has a major, to display the major

        public Student() {

        }

        public override string ToString() { //To display the results in the console.writeline
            return $"Id[{this.Id}] | Firstname:{this.Firstname} | Lastname:{this.Lastname} | SAT Score:{this.SAT} | GPA:{this.GPA} | Full-Time:{this.IsFulltime} | Major:{this.Major}";

        }

    }
}
