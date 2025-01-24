using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Employee",
                DateOfBirth = new DateTime(1990, 1, 1)
            };
            return View(data);
        }

    }
}
