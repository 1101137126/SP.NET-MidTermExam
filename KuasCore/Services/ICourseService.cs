using KuasCore.Dao;
using KuasCore.Models;
using System.Collections.Generic;

namespace KuasCore.Services
{

    /// <summary>
    ///     員工資料維護的 Service.
    /// </summary>
    public interface ICourseService
    {

        /// <summary>
        ///     新增員工資料.
        /// </summary>
        /// <param name="employee">
        ///     員工資料.
        /// </param>
        void AddEmployee(Course employee);

        /// <summary>
        ///     修改員工資料.
        /// </summary>
        /// <param name="employee">
        ///     員工資料.
        /// </param>
        
        IList<Course> GetAllEmployees();

        /// <summary>
        ///     依據 ID 取得員工資料.
        /// </summary>
        /// <param name="id">
        ///     員工 Id.
        /// </param>
        /// <returns>
        ///     該員工資料.
        /// </returns>
        Course GetEmployeeById(string id);

    }
}
