namespace DQC.Comics.ResourcePlanner.Controllers
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult About()
        {
            this.ViewBag.Message = "Your application description page.";

            return this.View();
        }
        public ActionResult Missions()
        {
            return this.View();
        }
        public ActionResult Completed()
        {
            return this.View();
        }
        public ActionResult BiReport()
        {
            return this.View();
        }
        public ActionResult Contact()
        {
            this.ViewBag.Message = "Your contact page.";

            return this.View();
        }
    }
}