
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class CourseDao : GenericDao<Course>, ICourseDao
    {

        override protected IRowMapper<Course> GetRowMapper()
        {
            return new CourseRowMapper();
        }

        public void AddCourse(Course course)
        {
            string command = @"INSERT INTO Course (CourseId, CourseName, CourseDescription) VALUES (@CourseId, @CourseName, @CourseDescription);";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("CourseId", DbType.String).Value = course.CourseId;
            parameters.Add("CourseName", DbType.String).Value = course.CourseName;
            parameters.Add("CourseAge", DbType.Int32).Value = course.CourseDescription;

            ExecuteNonQuery(command, parameters);
        }

        public IList<Course> GetAllCourses()
        {
            string command = @"SELECT * FROM Course ORDER BY CourseId ASC";
            IList<Course> courses = ExecuteQueryWithRowMapper(command);
            return courses;
        }

        public Course GetCourseByCourseId(string id)
        {
            string command = @"SELECT * FROM Course WHERE CourseId = @CourseId";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("CourseId", DbType.String).Value = id;

            IList<Course> course = ExecuteQueryWithRowMapper(command, parameters);
            if (course.Count > 0)
            {
                return course[0];
            }

            return null;
        }

    }
}
