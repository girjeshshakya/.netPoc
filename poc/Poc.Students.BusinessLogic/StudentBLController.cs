using System;
using Poc.Students.DataAccessLogic;

namespace Poc.Students.BusinessLogic
{
    public class StudentBLController : IStudentBLController
    {

        private IStudentDao _studentDao;
        public StudentBLController(IStudentDao studentDao)
        {
            _studentDao = studentDao;
        }

        public string GetStudent()
        {
            return _studentDao.GetStudents();
        }
    }
}
