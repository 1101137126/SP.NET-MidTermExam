using KuasCore.Dao;
using KuasCore.Models;
using KuasCore.Services;
using KuasCore.Services.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Testing.Microsoft;
using System;

namespace KuasCoreTests.Services
{
    [TestClass]
    public class CourseServiceUnitTest : AbstractDependencyInjectionSpringContextTests
    {

        #region Spring 單元測試必寫的內容

        override protected string[] ConfigLocations
        {
            get
            {
                return new String[] { 
                    //assembly://MyAssembly/MyNamespace/ApplicationContext.xml
                    "~/Config/KuasCoreDatabase.xml",
                    "~/Config/KuasCorePointcut.xml",
                    "~/Config/KuasCoreTests.xml" 
                };
            }
        }

        #endregion

        public ICourseService CourseService { get; set; }

        [TestMethod]
        public void TestCourseService_AddCourse()
        {
            Course course = new Course();
            course.CourseId = "00000";
            course.CourseName = "11111";
            course.CourseDescription = "0104153";
            CourseService.AddCourse(course);

            Course dbCourse = CourseService.GetCourseByCourseId(course.CourseId);
            Assert.IsNotNull(dbCourse);
            Assert.AreEqual(course.CourseId, dbCourse.CourseId);

            Console.WriteLine("課程編號為 = " + dbCourse.CourseId);
            Console.WriteLine("課程名稱為 = " + dbCourse.CourseName);
            Console.WriteLine("課程描述為 = " + dbCourse.CourseDescription);

           /* EmployeeService.DeleteEmployee(dbEmpolyee);
            dbEmpolyee = EmployeeService.GetEmployeeById(empolyee.Id);
            Assert.IsNull(dbEmpolyee);*/
        }

        

        [TestMethod]
        public void TestEmployeeService_GetCourseByCourseId()
        {
            Course course = CourseService.GetCourseByCourseId("dennis_yen");
            Assert.IsNotNull(course);

            Console.WriteLine("課程編號為 = " + course.CourseId);
            Console.WriteLine("課程名稱為 = " + course.CourseName);
            Console.WriteLine("課程描述為 = " + course.CourseDescription);
        }

    }
}
