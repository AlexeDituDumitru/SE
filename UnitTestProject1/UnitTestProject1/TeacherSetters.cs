using ApplicationModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class TeacherSetters
    {
        [TestMethod]
        public void TestSetTeacherFirstName()
        {
            Teacher teacher = new Teacher
            {
                FirstName = "Ion",

            };
            Assert.IsNotNull(teacher.FirstName);
 
        }

        [TestMethod]
        public void TestSetTeacherLastName()
        {
            Teacher teacher = new Teacher
            {
                
                LastName = "Popescu",
           
            };
            Assert.IsNotNull(teacher.LastName);

        }

        [TestMethod]
        public void TestSetTeacherEmail()
        {
            Teacher teacher = new Teacher
            {

                Email = "Ion@yahoo.com"
            };

            Assert.IsNotNull(teacher.Email);
        }




    }
}
