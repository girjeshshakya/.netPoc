using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Poc.Students.BusinessLogic;

namespace poc.Controllers
{
    public class StudentController : ApiController
    {
        private IStudentBLController _studentBLController;

        public StudentController(IStudentBLController repo)
        {
            _studentBLController = repo;
        }

        public string Get()
        {
            return _studentBLController.GetStudent();
        }

    }
}
