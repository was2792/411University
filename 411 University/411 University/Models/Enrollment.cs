using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _411_University.Models
{

    public enum Grade
    {
        A, B, C, D, E, F, Pass, Fail
    }
   
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int CourseID { get; set; }
        public int StudentId { get; set; }
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
        
    }
}