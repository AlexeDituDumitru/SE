using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace test.Models.DomainModels
{
    public class Attendance
    {
        public int Id { get; set; }
        public int LaboratoryId { get; set; }
        public virtual Lab Laboratory { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        
    }
}
