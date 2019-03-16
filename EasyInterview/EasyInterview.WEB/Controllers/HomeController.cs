using System.Linq;
using EasyInterview.BLL.Interfaces;
using System.Web.Mvc;

namespace EasyInterview.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService _service;

        public HomeController(IService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            var test = _service.GetAll().FirstOrDefault();

            return View(test);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}