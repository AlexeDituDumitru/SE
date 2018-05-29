using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models.DomainModels;

namespace test.ViewModels.TeacherVM
{
    public class TeachersList
    {
        public IEnumerable<Teacher> teachers { get; set; }
        public List<Lab> labs { get; internal set; }
    }
}
