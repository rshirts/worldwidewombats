using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeGUI_UnitTest
{
    [TestClass]
    public class EmployeeGUITest
    {
        [TestMethod]
        public void employee_add_get()
        {
            EmployeeGUI.BusinessRules employeeList = EmployeeGUI.BusinessRules.Instance;
            EmployeeGUI.Salary testEmployee = new EmployeeGUI.Salary();
            EmployeeGUI.Salary testEmployee2 = new EmployeeGUI.Salary();

            uint testId = 123;
            double testDouble = 1234.56;
            string testName = "testName";
            testEmployee.FirstName = testName;
            testEmployee.LastName = testName;
            testEmployee.EmpID = testId;
            testEmployee.EmpType = "SALARY";
            testEmployee.MonthlySalary = testDouble;

            //act
            employeeList.Add(testEmployee);
            testEmployee2 = (EmployeeGUI.Salary)employeeList[testId];

            //assert
            Assert.AreEqual(testEmployee.EmpID, testEmployee2.EmpID);
        }
        //this also checks to see if the education dictionary is working.
        [TestMethod]
        public void serialize_and_deserialize()
        {
            //arrange
            EmployeeGUI.BusinessRules employeeListSave = EmployeeGUI.BusinessRules.Instance;
            EmployeeGUI.BusinessRules employeeListLoad = EmployeeGUI.BusinessRules.Instance;
            EmployeeGUI.Salary testEmployee = new EmployeeGUI.Salary();
            EmployeeGUI.Salary testEmployee2 = new EmployeeGUI.Salary();
            EmployeeGUI.FileIO saveThis = new EmployeeGUI.FileIO();

            uint testId = 123;
            double testDouble = 1234.56;
            string testName = "testName";
            testEmployee.FirstName = testName;
            testEmployee.LastName = testName;
            testEmployee.EmpID = testId;
            testEmployee.EmpType = "SALARY";
            testEmployee.MonthlySalary = testDouble;

            EmployeeGUI.Course courseToAdd = new EmployeeGUI.Course();

            courseToAdd.CourseID = "1";
            courseToAdd.Description = "1";
            courseToAdd.Grade = "1";
            courseToAdd.Date = "1";
            courseToAdd.Credits = "1";
            testEmployee.Education.Add(courseToAdd.CourseID, courseToAdd);
            


            //act
            employeeListSave.Add(testEmployee);
            saveThis.EmployeeDB = EmployeeGUI.BusinessRules.EmpDictionary;
            saveThis.CloseFileDB();


            saveThis.OpenFileDB();
            testEmployee2 = (EmployeeGUI.Salary)employeeListLoad[testId];

            //assert
            Assert.AreEqual(testEmployee.EmpID, testEmployee2.EmpID);
            Assert.AreEqual(testEmployee2.Education["1"].CourseID, testEmployee.Education["1"].CourseID);
        }

    }
}