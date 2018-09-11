using System.Web.Mvc;

namespace PD.Kendo.Controllers
{
    public class HelpController : Controller
    {
        public ActionResult Index() 
        {
            return this.View();
        }

        public ActionResult WidgetBinding() 
        {
            return this.View();
        }
    }
}