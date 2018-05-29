using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.ViewModels.TeacherVM;
using test.Data;
using Microsoft.EntityFrameworkCore;
using test.Models.DomainModels;

namespace test.Controllers
{
    [Authorize]
    public class AdminController : Controller
    { 
        public static ApplicationDbContext dbContext1 = null;

        public AdminController(ApplicationDbContext dbContext)
        {
            dbContext1 = dbContext;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult AdminTeacher()
        {
            TeachersList vm = new TeachersList();
            vm.teachers = dbContext1.teachers.AsEnumerable();
            return View(vm);
        }

       
    }
}
