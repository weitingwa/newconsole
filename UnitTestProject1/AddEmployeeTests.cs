using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassEmployee;

namespace EmployeeTests

{
    [TestClass]
    public class AddEmployeeTests
    {

        [TestMethod]
        public void Test_Add_Employee_age_19()
        {
            Employee Cindy = new Taiwaneese("Cindy", 19);
            Cindy.age = 19;

            Assert.AreEqual(Cindy.hire(), false);
        }

        [TestMethod]
        public void Test_Add_Employee_age_24()
        {
 
            Employee Cindy = new Taiwaneese("Cindy", 24);
            Cindy.age = 24;
            
            Assert.AreEqual(Cindy.hire(), true);
        }
    }
}
