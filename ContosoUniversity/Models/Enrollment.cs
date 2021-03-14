using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-10-zbwsdhr-dykstra2] - input the gradebook
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        //tinfo200:[2021-03-10-zbwsdhr-dykstra2] - declare all elements in enrollment entity
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
