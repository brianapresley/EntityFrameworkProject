using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFrameworkProject.Models {
    public class Major {

        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Description { get; set; }
        [Range(600, 2400)]
        public int MinSAT { get; set; }

        public Major() {

        }

        public override string ToString() { //To display the results in the console.writeline
            return $"Id: {this.Id}, Desc:{this.Description}, MinSAT:{this.MinSAT}";
        }
    }
}
