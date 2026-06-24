using Microsoft.AspNetCore.Mvc;

namespace MVC_CodeFirstApproch.Controllers
{
    public class collegeController : Controller
    {
        
        //public string collegename()
        //{
        //         return "ABC College";
        //}

        public ViewResult collegename()
        {
            return View();
        }


    }
}
