using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models.DomainModels;

namespace test.ViewModels
{
    public class TeacherLabsVM
    {
        public int Id { get; set; }        
        public SelectList Labs {get; set;}
        public SelectList Groups { get; set; }
        public int SelectedLab { get; set; }
        public string SelectedGroup { get; set; }
        public Lab LabToCreate { get; set; }
    }
}
