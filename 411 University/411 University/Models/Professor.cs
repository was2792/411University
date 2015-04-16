using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _411_University.Models
{

    public enum Department
    {
        Business, Art, Mathmatics, English, Engineering, Music, Humanities
    }
    public class Professor
    {
        public int ProfessorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }
        public int YearsTeaching { get; set; }
    }
}