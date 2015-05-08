using KuasCore.Dao;
using KuasCore.Dao.Impl;
using KuasCore.Models;
using System.Collections.Generic;

namespace KuasCore.Services.Impl
{
    public class CourseService : ICourseService
    {

        public ICourseDao CourseDao { get; set; }

        public void AddCourse(Course course)
        {
            CourseDao.AddCourse(course);
        }


        public IList<Course> GetAllCourses()
        {
            return CourseDao.GetAllCourses();
        }

        public Course GetCourseByCourseId(string id)
        {
            return CourseDao.GetCourseByCourseId(id);
        }

    }

}
