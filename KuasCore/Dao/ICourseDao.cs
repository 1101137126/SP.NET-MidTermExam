using KuasCore.Models;
using System;
using System.Collections.Generic;

namespace KuasCore.Dao
{
    public interface ICourseDao
    {

        void AddCourse(Course course);

        IList<Course> GetAllEmployees();

        Course GetCourseByCourseId(string id);


        IList<Course> GetAllCourses();
    }
}
