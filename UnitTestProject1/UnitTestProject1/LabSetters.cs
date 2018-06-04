using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using test.Models.DomainModels;

namespace UnitTestProject1
{
    [TestClass]
    public class LabSetters
    {
        [TestMethod]
        public void TestSetLabName()
        {
            Lab lab = new Lab
            {
                Name = "WAD"

            };
            Assert.IsNotNull(lab.Name);

        }

        [TestMethod]
        public void TestSetLabConditionToPass()
        {
            Lab lab = new Lab
            {
                ConditionToPass = 5

            };
            Assert.IsNotNull(lab.ConditionToPass);

        }

        [TestMethod]
        public void TestSetLabDescription()
        {
            Lab lab = new Lab
            {
                Description = "description"

            };
            Assert.IsNotNull(lab.Description);

        }

        [TestMethod]
        public void TestSetNumberOfWeeks()
        {
            Lab lab = new Lab
            {
                NumberOfWeeks = 8

            };
            Assert.IsNotNull(lab.NumberOfWeeks);

        }

        [TestMethod]
        public void TestSetTeacher()
        {
            Teacher teacher = new Teacher { };
            Lab lab = new Lab
            {
                Teacher = teacher

            };
            Assert.IsNotNull(lab.Teacher);

        }
    }
}
