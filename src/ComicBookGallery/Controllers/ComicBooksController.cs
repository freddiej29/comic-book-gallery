using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Text; 
using System.Threading.Tasks;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/");
            }

            return Content("Hello from the Comic Books controller!");
        }
    }
}
