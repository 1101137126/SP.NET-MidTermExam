using KuasCore.Dao;
using KuasCore.Dao.Impl;
using KuasCore.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Testing.Microsoft;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace KuasCoreTests.Dao
{

    [TestClass]
    public class CourseDaoUnitTest : AbstractDependencyInjectionSpringContextTests
    {
        #region 單元測試 Spring 必寫的內容 
        
        override protected string[] ConfigLocations
        {
            get
            {
                return new String[] { 
                    // assembly://MyAssembly/MyNamespace/ApplicationContext.xml
                    "~/Config/KuasCoreDatabase.xml",
                    "~/Config/KuasCoreTests.xml" 
                };
            }
        }

        #endregion

        public ICourseDao CourseDao { get; set; }


        [TestMethod]
        public void TestCourseDao_AddCourse()
        {
            Course course = new Course();
            course.CourseId = "UnitTests";
            course.CourseName = "單元測試";
            course.CourseDescription = "2132133";
            CourseDao.AddCourse(course);

            Course dbCourse = CourseDao.GetCourseByCourseId(course.CourseId);
            Assert.IsNotNull(dbCourse);
            Assert.AreEqual(course.CourseId, dbCourse.CourseId);

            Console.WriteLine("課程編號為 = " + dbCourse.CourseId);
            Console.WriteLine("課程名稱為 = " + dbCourse.CourseName);
            Console.WriteLine("課程描述為 = " + dbCourse.CourseDescription);

            /*EmployeeDao.DeleteEmployee(dbEmployee);
            dbEmployee = EmployeeDao.GetEmployeeById(employee.Id);
            Assert.IsNull(dbEmployee);*/
        }

       

        [TestMethod]
        public void TestCourseDao_GetCourseByCourseId()
        {
            Course course = CourseDao.GetCourseByCourseId("dennis_yen");
            Assert.IsNotNull(course);
            Console.WriteLine("課程編號為 = " + course.CourseId);
            Console.WriteLine("課程名稱為 = " + course.CourseName);
            Console.WriteLine("課程描述為 = " + course.CourseDescription);
        }

    }
}
