using Microsoft.AspNetCore.Mvc;
using MVC_CodeFirstApproch.EFMVCORMDB;
using MVC_CodeFirstApproch.Models;
using System.Threading.Tasks;

namespace MVC_CodeFirstApproch.Controllers
{
    public class StudentController : Controller
    {


        ORMCLASSFORDB dbcontextobj;

        // StudentController needs ORMCLASSFORDB to talk to the database.
        //So ORMCLASSFORDB is a dependency of StudentController.
        //Whenever ASP.NET Core creates StudentController, it automatically creates (or retrieves) an ORMCLASSFORDB object and passes it into the context parameter. Then we store that object in dbcontextobj for later use.-->Dependency injection
        public StudentController(ORMCLASSFORDB context)
        {
            dbcontextobj = context;
        }
        public ViewResult showStdData()
        {

            //ORMCLASSFORDB obj = new ORMCLASSFORDB();
            //var stdData = obj.StudentInformations.ToList();


           var stdData= dbcontextobj.StudentInformations.ToList();
           var stdData2 = dbcontextobj.StudentInformations.SingleOrDefault(s => s.Id == 2);


            return View("StudentData",stdData2);


         
         }
        public ViewResult Allstddata()

        {
            var val = dbcontextobj.StudentInformations.ToList();
            return View(val);
        }
        public ViewResult Mainpage()
        {
            return View();
        }


       
    }
}
