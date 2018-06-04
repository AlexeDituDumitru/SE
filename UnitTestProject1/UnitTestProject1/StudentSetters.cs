using ApplicationModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using test.Models.DomainModels;

namespace UnitTestProject1
{
    [TestClass]
     public class StudentSetters
    {
        [TestMethod]
        public void TestSetStudentFirstName()
        {
            Student student = new Student
            {
                FirstName = "Alex"

            };
            Assert.IsNotNull(student.FirstName);

        }

        [TestMethod]
        public void TestSetStudentLastName()
        {
            Student student = new Student
            {
                LastName = "Ionescu"

            };
            Assert.IsNotNull(student.LastName);

        }

        [TestMethod]
        public void TestSetStudentGroup()
        {
            Student student = new Student
            {
                Group = "1.2"

            };
            Assert.IsNotNull(student.Group);

        }

        [TestMethod]
        public void TestSetStudentEmail()
        {
            Student student = new Student
            {
                Email = "Alex@yahoo.com"

            };
            Assert.IsNotNull(student.Email);

        }
        [TestMethod]
        public void TestSetStudentYear()
        {
            Student student = new Student
            {
                Year = "1"

            };
            Assert.IsNotNull(student.Year);

        }
    }
}
