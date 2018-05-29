using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Models.DomainModels
{
    public class Lab
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ConditionToPass { get; set; }
        public int NumberOfWeeks { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
