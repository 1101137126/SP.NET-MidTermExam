using KuasCore.Dao;
using KuasCore.Dao.Impl;
using KuasCore.Models;
using System;
using System.Collections.Generic;

namespace KuasCore.Services.Impl
{
    public class TxCourseService : ITxCourseService
    {

        public ICourseDao EmployeeDao { get; set; }

        public void ExecuteTxMethod()
        {
            Course course1 = new Course();
            course1.CourseId = "AAA";
            course1.CourseName = "AAA";
            course1.CourseDescription = "111";
            CourseDao.AddCourse(course1);

            Course course2 = new Course();
            course2.CourseId = "BBB";
            course2.CourseName = "BBB";
            course2.CourseDescription = "222";
            CourseDao.AddCourse(course2);

            Course dbCourse = CourseDao.GetCourseByCourseId("AAA");
            dbCourse.CourseName = "XXX";

            throw new Exception("Get an exception");
        }

    }

}
