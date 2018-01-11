using DAL;
using System.Linq;
using System.Web.Mvc;

namespace IdentitySample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //CarContext context;
        //public HomeController()
        //{
        //    context = new CarContext();
        //}
        //// GET: Car
        //public ActionResult Index(int id = 1)
        //{
        //    ViewBag.Count = context.CARSINFO.ToList().Count();
        //    var model = context.CARSINFO;
        //    ViewBag.Index = id;
        //    return View();
        //}
        //public PartialViewResult GetCarsList(int id = 1)
        //{
        //    var res = context.CARSINFO.ToList().Skip((id - 1) * 2).Take(2);
        //    return PartialView(res);
        //}
    }
}
