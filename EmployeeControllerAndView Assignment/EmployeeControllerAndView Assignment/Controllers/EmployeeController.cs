using Microsoft.AspNetCore.Mvc;
namespace EmployeeControllerAndView_Assignment.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeController
        public ActionResult Index()
        {
            return View();
        }
        //Employee Data View
        public ActionResult EmployeeData()
        {
            return View();
        }
        public ActionResult Congratulations()
        {
            return View();
        }
    }  
}