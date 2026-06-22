using Microsoft.AspNetCore.Mvc;
using MVC_CodeFirstApproch.EFMVCORMDB;
using MVC_CodeFirstApproch.Models;

namespace MVC_CodeFirstApproch.Controllers
{
    public class StudentController : Controller
    {

      
        public ViewResult showStdData()
        {

            ORMCLASSFORDB obj = new ORMCLASSFORDB();
            var stdData = obj.StudentInformations;


            return View();


         
         }


       
    }
}
