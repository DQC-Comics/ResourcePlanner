namespace DQC.Comics.ResourcePlanner.Controllers
{
    using Microsoft.Ajax.Utilities;
    using Microsoft.SharePoint.Client.Utilities;
    using ResourcePlannerAppWeb;
    using System.Collections.Generic;
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
        public ActionResult AssaultReport()
        {
            return this.View();
        }
        public ActionResult Reporter()
        {
            return this.View();
        }

        [HttpGet]
        public void SendMail(string subject, string body)
        {
            var spContext = SharePointContextProvider.Current.GetSharePointContext(HttpContext);
            using (var clientContext = spContext.CreateUserClientContextForSPHost())
            {
                var emailp = new EmailProperties();
                emailp.To = new List<string> { "spider-man@aspc1607.onmicrosoft.com" };
                emailp.From = "admin@aspc1607.onmicrosoft.com";
                emailp.Body = body;
                emailp.Subject = subject;

                Utility.SendEmail(clientContext, emailp);
                clientContext.ExecuteQuery();
            }
        }
    }
}