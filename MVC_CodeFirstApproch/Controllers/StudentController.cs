using Microsoft.AspNetCore.Mvc;
using MVC_CodeFirstApproch.EFMVCORMDB;
using MVC_CodeFirstApproch.Models;

namespace MVC_CodeFirstApproch.Controllers
{
    public class StudentController : Controller
    {

        ORMCLASSFORDB dbcontextobj;

        public StudentController(ORMCLASSFORDB context)
        {
            dbcontextobj = context;
        }
        public ViewResult showStdData()
        {

            //ORMCLASSFORDB obj = new ORMCLASSFORDB();
            //var stdData = obj.StudentInformations.ToList();


            var stdData2= dbcontextobj.StudentInformations.ToList();


            return View(stdData2);


         
         }


       
    }
}
