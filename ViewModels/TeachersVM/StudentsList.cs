using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;
using test.Models.DomainModels;

namespace test.ViewModels.TeacherVM
{
    public class StudentsList
    {
        public IEnumerable<Student> students { get; set; }
     }
}
