using System.Linq;
using System.Web.Mvc;

namespace PD.Kendo.Controllers
{
    public class ThemeController : Controller
    {
        public JsonResult Get(string text)//, DataSourceRequest request) 
        {
            var themes = Definitions.Themes.OrderBy(e => e).Select(e=> new DataPair {
                Name = e,
                Value = e.ToLower().Replace(" ", "")
            });

            if (!string.IsNullOrWhiteSpace(text)) 
            {
                themes = themes.Where(e => e.Name.ToLower().Contains(text.ToLower()));
            }

            return Json(themes, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Preview() 
        {
            return View();
        }
    }

    public class DataPair
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}