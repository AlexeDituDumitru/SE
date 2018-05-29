using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using test.Data;
using test.Models;
using test.Models.DomainModels;
using test.Models.ManageViewModels;
using test.Services;
using test.ViewModels;
using test.ViewModels.TeacherVM;



namespace test.Controllers
{

    [Authorize(Roles = "Teacher")]
    public class TeacherController : Controller
    {
        public static ApplicationDbContext dbContext1 = null;

        public TeacherController(ApplicationDbContext dbContext)
        {
            dbContext1 = dbContext;
        }
        public IActionResult Attendance()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Attendance(int id)
        {
            TeacherLabsVM vm = new TeacherLabsVM();
            vm.Id = id;

            var teacherLabs = dbContext1.labs.Where(lab => lab.TeacherId == id).AsEnumerable();
            vm.Labs = new SelectList(teacherLabs, "Id", "Name");
            return View(vm);
        }
        
        [HttpPost]
        public IActionResult AssignGroupToLab([FromForm]TeacherLabsVM vm)
        {
            var currentLab = dbContext1.labs.FirstOrDefault(lab => lab.Id == vm.SelectedLab);
            if (currentLab != null)
            {
                //var currentGroup = dbContext1.Groups.FirstOrDefault(group => group.Id == vm.SelectedGroup);
                //currentLab.Groups.Add(currentGroup);
                //dbContext1.SaveChanges();
            }
            return RedirectToAction("Attendance");
        }
        public IActionResult TeacherMessages()
        {
            return View();
        }
       
        public async Task<IActionResult> TeacherStudents()
        {
            return View(await dbContext1.students.ToListAsync());
        }
        [HttpPost]
        public ActionResult Create(TeacherStudentVM model)
        {
            if (ModelState.IsValid)
            {
                dbContext1.students.Add(new Student
                {
                    FirstName = model.FirstName,
                    Year = model.Year
                });
                dbContext1.SaveChanges();

            }

            return View(model);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await dbContext1.students.SingleOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Email,OfficialGroup,Group,Year")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    dbContext1.Update(student);
                    await dbContext1.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(TeacherStudents));
            }
            return View(student);
        }
        private bool StudentExists(int id)
        {
            return dbContext1.students.Any(e => e.Id == id);
        }


    }
}